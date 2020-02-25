using Application.Lib.Payment;
using Application.Lib.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Application.Tests.Payment
{
    [TestClass]
    public class SafePaymentTests
    {
        [TestMethod]
        public void SuccessPay()
        {
            // Arrange
            var amount = 10M;
            var mock = new Mock<IValidator>();
            mock.Setup(m => m.Valid(amount)).Returns(true);

            var service = new SafePayment(mock.Object);

            // Act
            var result = service.Pay(amount);

            // Assert
            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.TransactionId);
        }

        [TestMethod]
        public void FailPay()
        {
            // Arrange
            var mock = Mock.Of<IValidator>();
            var service = new SafePayment(mock);
            var amount = 1M;

            // Act
            var result = service.Pay(amount);

            // Assert
            Mock.Get(mock).Verify(m => m.Valid(amount));
            Assert.IsFalse(result.Success);
        }
    }
}
