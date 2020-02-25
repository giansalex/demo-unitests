using Application.Lib.Payment;
using Application.Lib.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Payment
{
    [TestClass]
    public class SafePaymentTests
    {
        [TestMethod]
        public void SuccessPay()
        {
            // Arrange
            var service = new SafePayment(new AmountValidator());
            var amount = 10M;

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
            var service = new SafePayment(new AmountValidator());
            var amount = 1M;

            // Act
            var result = service.Pay(amount);

            // Assert
            Assert.IsFalse(result.Success);
        }
    }
}
