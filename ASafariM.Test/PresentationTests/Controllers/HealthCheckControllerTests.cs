using System;
using System.Threading.Tasks;
using ASafariM.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.PresentationTests.Controllers
{
    [TestClass]
    public class HealthCheckControllerTests
    {
        private Mock<ILogger<HealthCheckController>> _loggerMock = null!;
        private Mock<IConfiguration> _configurationMock = null!;
        private HealthCheckController _controller = null!;

        [TestInitialize]
        public void Setup()
        {
            _loggerMock = new Mock<ILogger<HealthCheckController>>();
            _configurationMock = new Mock<IConfiguration>();

            // Setup default configuration
            _configurationMock
                .Setup(c => c.GetConnectionString("DefaultConnection"))
                .Returns("Server=localhost;Database=testdb;User=test;Password=test;");

            _controller = new HealthCheckController(_loggerMock.Object, _configurationMock.Object);
        }

        [TestMethod]
        public void GetHealthStatus_ReturnsOkResult()
        {
            // Act
            var result = _controller.GetHealthStatus();

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);

            dynamic healthStatus = okResult.Value;
            Assert.IsNotNull(healthStatus);
            Assert.AreEqual("healthy", healthStatus.status);
            Assert.AreEqual("1.0.0", healthStatus.version);
            Assert.AreEqual("A. Safari M.", healthStatus.buildAuthor);
        }

        [TestMethod]
        public void GetHealthStatus_ContainsAllRequiredFields()
        {
            // Act
            var result = _controller.GetHealthStatus() as OkObjectResult;
            Assert.IsNotNull(result);
            dynamic healthStatus = result.Value;

            // Assert
            Assert.IsNotNull(healthStatus);
            Assert.IsNotNull(healthStatus.status);
            Assert.IsNotNull(healthStatus.version);
            Assert.IsNotNull(healthStatus.buildDate);
            Assert.IsNotNull(healthStatus.timestamp);
            Assert.IsNotNull(healthStatus.services);
        }

        [TestMethod]
        public void GetHealthStatus_ServicesContainAllComponents()
        {
            // Act
            var result = _controller.GetHealthStatus() as OkObjectResult;
            Assert.IsNotNull(result);
            dynamic healthStatus = result.Value;
            Assert.IsNotNull(healthStatus);
            dynamic services = healthStatus.services;

            // Assert
            Assert.IsNotNull(services);
            Assert.IsNotNull(services.database);
            Assert.IsNotNull(services.cache);
            Assert.IsNotNull(services.session);
            Assert.IsNotNull(services.api);
        }

        [TestMethod]
        public void GetGitCommitHash_ReturnsShortHash()
        {
            // Arrange & Act
            var result = _controller.GetHealthStatus() as OkObjectResult;
            Assert.IsNotNull(result);
            dynamic healthStatus = result.Value;
            Assert.IsNotNull(healthStatus);
            string? commitHash = healthStatus.buildCommit;

            // Assert
            Assert.IsNotNull(commitHash);
            Assert.AreEqual(8, commitHash.Length);
        }

        [TestMethod]
        public void GetDiskSpace_ReturnsValidValues()
        {
            // Act
            var result = _controller.GetHealthStatus() as OkObjectResult;
            Assert.IsNotNull(result);
            dynamic healthStatus = result.Value;
            Assert.IsNotNull(healthStatus);
            dynamic diskSpace = healthStatus.services.diskSpace;

            // Assert
            Assert.IsNotNull(diskSpace);
            Assert.IsNotNull(diskSpace.totalSpace);
            Assert.IsNotNull(diskSpace.freeSpace);
            Assert.IsTrue(
                Convert.ToInt64(diskSpace.totalSpace) >= Convert.ToInt64(diskSpace.freeSpace)
            );
        }

        [TestMethod]
        public void GetMemoryUsage_ReturnsValidValues()
        {
            // Act
            var result = _controller.GetHealthStatus() as OkObjectResult;
            Assert.IsNotNull(result);
            dynamic healthStatus = result.Value;
            Assert.IsNotNull(healthStatus);
            dynamic memoryUsage = healthStatus.services.memory;

            // Assert
            Assert.IsNotNull(memoryUsage);
            Assert.IsNotNull(memoryUsage.totalAllocated);
            Assert.IsNotNull(memoryUsage.used);
            Assert.IsTrue(Convert.ToInt64(memoryUsage.totalAllocated) >= 0);
            Assert.IsTrue(Convert.ToInt64(memoryUsage.used) >= 0);
        }

        [TestMethod]
        public void GetCpuUsage_ReturnsValidValue()
        {
            // Act
            var result = _controller.GetHealthStatus() as OkObjectResult;
            Assert.IsNotNull(result);
            dynamic healthStatus = result.Value;
            Assert.IsNotNull(healthStatus);
            dynamic cpuUsage = healthStatus.services.cpu;

            // Assert
            Assert.IsNotNull(cpuUsage);
            Assert.IsNotNull(cpuUsage.currentUsage);
            var usage = Convert.ToDouble(cpuUsage.currentUsage);
            Assert.IsTrue(usage >= 0 && usage <= 100);
        }
    }
}
