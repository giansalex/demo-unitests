using Application.Lib.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Validator
{
    [TestClass]
    public class AmountValidatorTests
    {
        [TestMethod]
        public void ValidAmount()
        {
            // Arrange
            var validator = new AmountValidator();
            var amount = 10M;

            // Act
            var result = validator.Valid(amount);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidAmount()
        {
            // Arrange
            var validator = new AmountValidator();
            var amount = 1M;

            // Act
            var result = validator.Valid(amount);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
