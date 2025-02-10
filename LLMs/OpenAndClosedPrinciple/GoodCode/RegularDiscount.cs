namespace LLMs.OpenAndClosedPrinciple.GoodCode
{
    public class RegularDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.1; // 10% discount
    }
}
