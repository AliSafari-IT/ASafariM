using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASafariM.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASafariM.Test.DomainTests.Entities
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_Should_Require_Valid_Email()
        {
            // Arrange
            var user = new User { Email = null }; // Email is required

            // Act
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(user);
            var isValid = Validator.TryValidateObject(
                user,
                validationContext,
                validationResults,
                true
            );

            // Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(validationResults.Any(v => v.MemberNames.Contains("Email")));
        }

        [TestMethod]
        public void User_Should_Require_Valid_PasswordHash()
        {
            // Arrange
            var user = new User { PasswordHash = null };

            // Act
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(user);
            var isValid = Validator.TryValidateObject(
                user,
                validationContext,
                validationResults,
                true
            );

            // Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(validationResults.Any(v => v.MemberNames.Contains("PasswordHash")));
        }

        [TestMethod]
        public void User_Should_Have_Default_Values()
        {
            // Arrange
            var user = new User();

            // Act & Assert
            Assert.IsTrue(user.IsActive);
            Assert.AreEqual(0, user.FailedLoginAttempts);
            Assert.IsFalse(user.IsAdmin);
        }
    }
}
