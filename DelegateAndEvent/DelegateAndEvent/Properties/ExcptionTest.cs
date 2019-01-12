using System;
namespace DelegateAndEvent.Properties
{
    public class ExcptionTest
    {

        public static void Method1()
        {
            Console.WriteLine("异常1被调用");
            throw new Exception("异常1抛出 ");
        }

        public static void Method2()
        {
            Console.WriteLine("异常2被调用");

        }

    }
}
