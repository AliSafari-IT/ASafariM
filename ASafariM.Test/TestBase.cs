using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test
{
    public abstract class TestBase
    {
        protected AppDbContext Context;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            Context = new AppDbContext(options);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Context.Dispose();
        }

        public TestBase(Mock<AppDbContext> context)
        {
            Context = context.Object ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
