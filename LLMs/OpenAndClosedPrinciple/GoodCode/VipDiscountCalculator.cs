namespace LLMs.OpenAndClosedPrinciple.GoodCode
{
    public class VipDiscountCalculator : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.2; // 20% discount
    }
}
