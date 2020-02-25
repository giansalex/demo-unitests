using System;
using Application.Lib.Validator;

namespace Application.Lib.Payment
{
    public class SafePayment : IPayService
    {
        private readonly IValidator _validator;

        public SafePayment(IValidator validator)
        {
            _validator = validator;
        }

        public PaymentResult Pay(decimal amount)
        {
            if (!_validator.Valid(amount))
            {
                return new PaymentResult
                {
                    Message = "Invalid Amount"
                };
            }

            return new PaymentResult
            {
                Success = true,
                Message = "Successfull Pay",
                TransactionId = Guid.NewGuid().ToString()
            };
        }
    }
}
