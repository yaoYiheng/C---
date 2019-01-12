using System;

namespace DelegateAndEvent
{
    //声明delegate
    public delegate void GreetingDelegate (string name);

    //声明带返回值的代理
    public delegate int NumDelegate();

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void GreatingDelegateTest()
        {
            

            NormalGreeting normalGreeting = new NormalGreeting();

            GreetingDelegate greeting = new GreetingDelegate(normalGreeting.NightGreeting);
            GreetingDelegate greeting1 = new GreetingDelegate(normalGreeting.MorningiGreeting);

            GreetingDelegate greeting2 = FestivalGreeting.XmasGreeting;

            GreetingDelegate[] delegates = { greeting1, greeting2 };

            //for (int i = 0; i < delegates.Length; i++)
            //{
            //    delegates[i]("Morris"); 
            //}

            Console.WriteLine("---------");
            //组合委托
            // 委托可以使用"+"运算符来组合, 这个运算最终会创建一个新的委托, 其调用列表连接了作为操作数的
            //两个委托的调用列表副本

            GreetingDelegate greeting3 = greeting1 + greeting2 + greeting;
            greeting3("Morris");
            Console.WriteLine("---------");
            //移除
            greeting3 -= greeting1;

            greeting3("morris");  
        }
    }
}
