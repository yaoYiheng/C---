using System;

namespace DelegateAndEvent
{
    //声明delegate
    public delegate void GreetingDelegate (string name);

    //声明带返回值的代理
    public delegate int NumDelegate();

    //带有返回值, 参数为值类型
    public delegate int NumOperatorDelegate(int num);


    //带有返回值, 参数为引用类型
    public delegate int NumRefDelegate(ref int num);
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //NumDelegateTest();

            NumOperatorTest();

            //NumRefTest();
        }



        static void NumRefTest()
        {
            int num = 100;

            NumRefDelegate numOperatorDelegate = NumRef.NumRefTest1;
            numOperatorDelegate += NumRef.NumRefTest2;


            Console.WriteLine(numOperatorDelegate(ref num));


        }

        static void NumOperatorTest()
        {
            int num = 10;

            NumOperatorDelegate numOperatorDelegate = NumOprator.NumInCreaseTest1;

            numOperatorDelegate += NumOprator.NumDecreaseTest2;

            Console.WriteLine(numOperatorDelegate(num));


        }

        //返回值为int无参数委托测试;
        static void NumDelegateTest()
        {
            //创建委托对象
            NumDelegate numDelegate = NumTest.NumTest1;
            numDelegate += NumTest.NumTest2;

            numDelegate();
        }

        //无返回值委托测试
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
            //greeting3 -= greeting1;

            greeting3("morris");  
        }
    }
}
