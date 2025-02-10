namespace LLMs.OpenAndClosedPrinciple.BadCode
{
    public class BadDiscountCalculator
    {
        public double CalculateDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
            {
                return amount * 0.1; // 10% discount
            }
            else if (customerType == "VIP")
            {
                return amount * 0.2; // 20% discount
            }
            else if (customerType == "SuperVIP")
            {
                return amount * 0.3; // 30% discount
            }
            return 0;
        }
    }

}
