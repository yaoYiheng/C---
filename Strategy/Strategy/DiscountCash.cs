using System;
namespace Strategy
{
    public class DiscountCash : BaseCash
    {
        private double m_DiscountRate = 1d;

        public DiscountCash(string discountRate)
        {
            m_DiscountRate = double.Parse(discountRate);
        }
        public override double TakeCash(double amount)
        {
            return m_DiscountRate * amount;
        }
    }
}
