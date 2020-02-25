using System.Diagnostics.CodeAnalysis;

namespace Application.Lib.Payment
{
    [ExcludeFromCodeCoverage]
    public class PaymentResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string TransactionId { get; set; }
    }
}
