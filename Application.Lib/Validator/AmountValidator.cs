namespace Application.Lib.Validator
{
    public class AmountValidator : IValidator
    {
        private const decimal Min = 5;
        private const decimal Max = 3000;

        public bool Valid(decimal amount)
        {
            return amount >= Min && amount <= Max;
        }
    }
}
