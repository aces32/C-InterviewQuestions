namespace LLMs.OpenAndClosedPrinciple.GoodCode
{
    public class SuperVIPDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.3; // 30% discount
    }
}
