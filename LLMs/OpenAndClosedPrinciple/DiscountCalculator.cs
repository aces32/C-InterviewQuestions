namespace LLMs.OpenAndClosedPrinciple
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateDiscount(double amount)
        {
            return _discountStrategy.ApplyDiscount(amount);
        }
    }
}
