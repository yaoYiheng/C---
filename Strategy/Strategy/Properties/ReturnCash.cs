using System;
namespace Strategy.Properties
{
    public class ReturnCash: BaseCash
    {
        private double m_ReturnCondition = 0.0d;
        private double m_ReturnRate = 0.0d;

        public ReturnCash(string condition, string rate)
        {
            m_ReturnCondition = double.Parse(condition);
            m_ReturnRate = double.Parse(rate);
        }

        public override double TakeCash(double amount)
        {
            if (amount > m_ReturnCondition)
            {
                return amount - Math.Floor(amount / m_ReturnCondition) * m_ReturnRate;
            }

            return amount;

        }
    }
}
