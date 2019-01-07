using System;
namespace Strategy.Properties
{
    public class CashContext
    {
        private BaseCash m_BaseCash = null;
        //public CashContext(BaseCash baseCash)
        //{
        //    this.m_BaseCash = baseCash;
        //}

        //public double Calculate(double amount)
        //{
        //    return m_BaseCash.TakeCash(amount);
        //}


        public CashContext (string type)
        {
            switch(type)
            {
                case "正常":
                    m_BaseCash = new NormalCash();
                    break;
                case "打8折":
                    m_BaseCash = new DiscountCash("0.8");
                    break;
                case "满300, 返100":
                    m_BaseCash = new ReturnCash("300", "100");
                    break;
                default:
                    break;
            }
        }

        public double Calculate(double amount)
        {
            return m_BaseCash.TakeCash(amount);
        }
    }
}
