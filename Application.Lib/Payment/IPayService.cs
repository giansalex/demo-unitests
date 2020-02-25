namespace Application.Lib.Payment
{
    public interface IPayService
    {
        PaymentResult Pay(decimal amount);
    }
}
