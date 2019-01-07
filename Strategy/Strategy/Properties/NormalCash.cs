using System;
namespace Strategy.Properties
{
    public class NormalCash: BaseCash
    {

        public override double TakeCash(double amount)
        {
            return amount;
        }
    }
}
