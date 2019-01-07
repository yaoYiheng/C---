using System;
namespace Strategy.Properties
{
    public class CashContext
    {
        private BaseCash m_BaseCash;
        public CashContext(BaseCash baseCash)
        {
            this.m_BaseCash = baseCash;
        }

        public double Calculate(double amount)
        {
            return m_BaseCash.TakeCash(amount);
        }
    }
}
