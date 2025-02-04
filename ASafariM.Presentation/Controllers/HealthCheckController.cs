using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace ASafariM.Presentation.Controllers
{
    /// <summary>
    /// Provides health status information for the application.
    /// </summary>
    /// <remarks>
    /// This controller returns various health metrics including service status,
    /// uptime, memory and CPU usage, disk space, environment details, and active threads.
    /// </remarks>
    [ApiController]
    [Route("api/health")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;
        private readonly string _connectionString;

        public HealthCheckController(
            ILogger<HealthCheckController> logger,
            IConfiguration configuration
        )
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet]
        public IActionResult GetHealthStatus()
        {
            try
            {
                var healthStatus = new
                {
                    status = "healthy",
                    version = "1.0.0",
                    buildDate = GetBuildDate(),
                    buildCommit = GetGitCommitHash()?.Substring(0, 8),
                    buildBranch = GetGitBranchName(),
                    buildAuthor = "A. Safari M.",
                    timestamp = DateTime.UtcNow,
                    services = new
                    {
                        database = CheckDatabaseHealth(),
                        cache = CheckCacheHealth(),
                        session = CheckSessionHealth(),
                        api = "healthy",
                    },
                    uptime = GetUptime(),
                    memoryUsage = GetMemoryUsage(),
                    cpuUsage = GetCpuUsage(),
                    diskSpace = GetDiskSpace(),
                    environment = GetEnvironmentDetails(),
                    activeThreads = GetActiveThreads(),
                };

                _logger.LogInformation("Health check successful.");
                return Ok(healthStatus);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Health check failed: {ex.Message}");
                return StatusCode(500, new { status = "unhealthy", error = ex.Message });
            }
        }

        private string GetUptime()
        {
            try
            {
                var uptime =
                    DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime();
                return uptime.ToString(@"dd\.hh\:mm\:ss");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve uptime: {ex.Message}");
                return "Unknown";
            }
        }

        private object GetMemoryUsage()
        {
            try
            {
                var process = Process.GetCurrentProcess();
                return new
                {
                    totalAllocated = $"{GC.GetTotalMemory(false) / 1024 / 1024} MB",
                    used = $"{process.PrivateMemorySize64 / 1024 / 1024} MB",
                    workingSet = $"{process.WorkingSet64 / 1024 / 1024} MB",
                    peakPagedMemory = $"{process.PeakPagedMemorySize64 / 1024 / 1024} MB",
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve memory usage: {ex.Message}");
                return new { error = "Memory usage could not be retrieved" };
            }
        }

        private object GetCpuUsage()
        {
            try
            {
                var process = Process.GetCurrentProcess();
                var startCpuUsage = process.TotalProcessorTime;
                var startTime = DateTime.UtcNow;

                Thread.Sleep(500); // Allow time for CPU calculation

                var endCpuUsage = process.TotalProcessorTime;
                var endTime = DateTime.UtcNow;
                var cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
                var elapsedMs = (endTime - startTime).TotalMilliseconds;
                var cpuUsage = (cpuUsedMs / elapsedMs) * 100;

                return $"{Math.Round(cpuUsage, 2)} %";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve CPU usage: {ex.Message}");
                return "Unknown";
            }
        }

        private object GetDiskSpace()
        {
            try
            {
                var drive = DriveInfo.GetDrives().FirstOrDefault(d => d.IsReady);
                return drive != null
                    ? new
                    {
                        drive.Name,
                        totalSpace = $"{drive.TotalSize / 1024 / 1024 / 1024} GB",
                        freeSpace = $"{drive.TotalFreeSpace / 1024 / 1024 / 1024} GB",
                    }
                    : "Drive not available";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve disk space: {ex.Message}");
                return "Unknown";
            }
        }

        private object GetEnvironmentDetails()
        {
            try
            {
                return new
                {
                    machineName = Environment.MachineName,
                    osVersion = Environment.OSVersion.ToString(),
                    frameworkVersion = System
                        .Runtime
                        .InteropServices
                        .RuntimeInformation
                        .FrameworkDescription,
                    processArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString(),
                    environmentVariables = Environment
                        .GetEnvironmentVariables()
                        .Keys.Cast<string>()
                        .Take(5)
                        .ToDictionary(k => k, k => Environment.GetEnvironmentVariable(k)),
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve environment details: {ex.Message}");
                return "Unknown";
            }
        }

        private object GetActiveThreads()
        {
            try
            {
                return new { threadCount = Process.GetCurrentProcess().Threads.Count };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve thread count: {ex.Message}");
                return "Unknown";
            }
        }

        private string CheckDatabaseHealth()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                _logger.LogError(
                    "Database health check failed: Connection string is not configured"
                );
                return "unhealthy (no connection string)";
            }

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    // First try to connect
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Database connection failed: {ex.Message}");
                        return $"unhealthy (connection failed)";
                    }

                    // Then try to execute a simple query
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "SELECT 1";
                            command.CommandTimeout = 5; // 5 seconds timeout
                            command.ExecuteScalar();
                        }
                        _logger.LogInformation("Database health check successful");
                        return "healthy";
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Database query failed: {ex.Message}");
                        return $"unhealthy (query failed)";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Database health check failed: {ex.Message}");
                return $"unhealthy (general error)";
            }
        }

        private string CheckCacheHealth()
        {
            // Placeholder: Implement real cache connection check
            return "healthy";
        }

        private string CheckSessionHealth()
        {
            // Placeholder: Implement session store check
            return "healthy";
        }

        private string GetBuildDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private string GetGitCommitHash()
        {
            try
            {
                // Try multiple possible locations for the .git directory
                var possiblePaths = new[]
                {
                    "/var/www/asafarim", // Main project directory
                    Directory.GetCurrentDirectory(), // Current directory
                    Path.GetDirectoryName(Directory.GetCurrentDirectory()), // Parent of current directory
                    Environment.GetEnvironmentVariable("GIT_DIR"), // From environment variable
                }
                    .Where(p => !string.IsNullOrEmpty(p))
                    .Select(p => Path.Combine(p, ".git", "HEAD"))
                    .Where(p => System.IO.File.Exists(p));

                _logger.LogInformation(
                    $"Searching for git info in: {string.Join(", ", possiblePaths)}"
                );

                foreach (var gitHeadPath in possiblePaths)
                {
                    _logger.LogInformation($"Checking git path: {gitHeadPath}");
                    var refPath = System.IO.File.ReadAllText(gitHeadPath).Trim();

                    if (refPath.StartsWith("ref: "))
                    {
                        // It's a reference, follow it
                        var gitDir = Path.GetDirectoryName(gitHeadPath); // Path to .git directory
                        if (gitDir == null)
                        {
                            _logger.LogWarning(
                                "Could not determine git directory from path: {gitHeadPath}"
                            );
                            continue;
                        }

                        var branchRef = refPath.Substring(5).Trim(); // Remove "ref: "
                        if (string.IsNullOrEmpty(branchRef))
                        {
                            _logger.LogWarning("Branch reference is empty");
                            continue;
                        }

                        // Try in .git directory
                        var commitPath = Path.Combine(gitDir, branchRef);
                        if (System.IO.File.Exists(commitPath))
                        {
                            var hash = System.IO.File.ReadAllText(commitPath).Trim();
                            _logger.LogInformation($"Found commit hash in {commitPath}: {hash}");
                            return hash;
                        }

                        // Try in .git/refs directory
                        commitPath = Path.Combine(gitDir, "refs", branchRef);
                        if (System.IO.File.Exists(commitPath))
                        {
                            var hash = System.IO.File.ReadAllText(commitPath).Trim();
                            _logger.LogInformation($"Found commit hash in refs: {hash}");
                            return hash;
                        }

                        _logger.LogWarning($"Could not find commit file at {commitPath}");
                    }
                    else
                    {
                        // It's a direct commit hash
                        _logger.LogInformation($"Found direct commit hash: {refPath}");
                        return refPath;
                    }
                }

                // If we get here, try to get it from an environment variable
                var envCommit = Environment.GetEnvironmentVariable("GIT_COMMIT");
                if (!string.IsNullOrEmpty(envCommit))
                {
                    _logger.LogInformation($"Found commit hash from environment: {envCommit}");
                    return envCommit;
                }

                _logger.LogWarning("Could not find git commit hash in any location");
                return "Unknown";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve Git commit hash: {ex.Message}");
                return "Unknown";
            }
        }

        private string GetGitBranchName()
        {
            return "main"; // Change this dynamically if needed
        }
    }
}
