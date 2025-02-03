using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealthStatus()
        {
            var healthStatus = new
            {
                status = "healthy",
                version = "1.0.0",
                timestamp = DateTime.UtcNow,
                services = new
                {
                    database = CheckDatabaseHealth(),
                    cache = CheckCacheHealth(),
                    api = "healthy",
                },
                uptime = GetUptime(),
                memoryUsage = GetMemoryUsage(),
                cpuUsage = GetCpuUsage(),
                diskSpace = GetDiskSpace(),
                environment = GetEnvironmentDetails(),
                activeThreads = GetActiveThreads(),
            };

            return Ok(healthStatus);
        }

        private string GetUptime()
        {
            var uptime = DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime();
            return uptime.ToString(@"dd\.hh\:mm\:ss");
        }

        private object GetMemoryUsage()
        {
            var process = Process.GetCurrentProcess();
            return new
            {
                totalAllocated = GC.GetTotalMemory(false) / 1024 / 1024 + " MB",
                used = process.PrivateMemorySize64 / 1024 / 1024 + " MB",
                workingSet = process.WorkingSet64 / 1024 / 1024 + " MB",
                peakPagedMemory = process.PeakPagedMemorySize64 / 1024 / 1024 + " MB",
            };
        }

        private double GetCpuUsage()
        {
            var process = Process.GetCurrentProcess();
            var startCpuUsage = process.TotalProcessorTime;
            var startTime = DateTime.UtcNow;

            Thread.Sleep(500); // Allow some time for CPU calculation

            var endCpuUsage = process.TotalProcessorTime;
            var endTime = DateTime.UtcNow;
            var cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
            var elapsedMs = (endTime - startTime).TotalMilliseconds;
            var cpuUsage = (cpuUsedMs / elapsedMs) * 100;

            return Math.Round(cpuUsage, 2);
        }


        private object GetDiskSpace()
        {
            var drive = DriveInfo.GetDrives().FirstOrDefault(d => d.IsReady);
            return drive != null
                ? new
                {
                    drive.Name,
                    totalSpace = drive.TotalSize / 1024 / 1024 / 1024 + " GB",
                    freeSpace = drive.TotalFreeSpace / 1024 / 1024 / 1024 + " GB",
                }
                : "Drive not available";
        }

        private object GetEnvironmentDetails()
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

        private object GetActiveThreads()
        {
            return new { threadCount = Process.GetCurrentProcess().Threads.Count };
        }

        private string CheckDatabaseHealth()
        {
            // You may implement a real DB connection check
            return "healthy"; // Placeholder for real DB check
        }

        private string CheckCacheHealth()
        {
            // Implement cache connection check if needed (e.g., Redis, MemoryCache)
            return "healthy"; // Placeholder for cache health check
        }
    }
}
