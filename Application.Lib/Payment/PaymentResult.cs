﻿namespace Application.Lib.Payment
{
    public class PaymentResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string TransactionId { get; set; }
    }
}
