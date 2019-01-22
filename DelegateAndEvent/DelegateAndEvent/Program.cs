using System;
using DelegateAndEvent.Properties;

namespace DelegateAndEvent
{
    //声明delegate
    public delegate void GreetingDelegate (string name);

    //声明带返回值的代理
    public delegate int NumDelegate();

    //带有返回值, 参数为值类型
    public delegate int NumOperatorDelegate(int num);

    public delegate void ExceptionDelegate();

    public delegate void TeamDelegate(string name, params string[] names);

    //带有返回值, 参数为引用类型
    public delegate int NumRefDelegate(ref int num);

    public delegate void VariableDelegate(int num);

    public delegate int LambdaDelegate(int num);
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //NumDelegateTest();

            //NumOperatorTest();

            //NumRefTest();

            //ExceptionTest();

            //匿名方法
            //AnoymouseMethodTest();

            //TeamIntroduce("蓝队", "包", "猪", "头");
            //TeamIntroduce("红队", "鸡", "狗");

            //TeamDelegateTest();

            //VariableTest();

            LambdaTest();
        }


        static void LambdaTest()
        {
            //lambda正常状态.
            //LambdaDelegate lambda = delegate (int num)
            //{
            //    return num * num;
            //};

            //关键字delegate可以省略
            //在参数裂变与匿名方法主体之间, 放Lambda运算符 "=>"
            //Lambda表达式可省略参数类型
            //以上可以改写为
            //LambdaDelegate lambda = (num) =>
            //{
            //    return num * num;
            //};

            //如果只有一个隐式类型参数, 可省略圆括号
            LambdaDelegate lambda = num =>  num * num;

            //如果匿名方法没有参数, 必须使用空的圆括号
            NumDelegate numDelegate = () => 1000;

            //记得调用的是需要添加()括号.
            Console.WriteLine("调用没有参数的委托: " + numDelegate());

            Console.WriteLine(lambda(20));
        }

        static void VariableTest()
        {
            int temp = 40;


            //在这里temp可以被作用域内部所捕获, 但是这里并没有进行计算, 而只是初始化
            VariableDelegate variableDelegate = delegate (int x)
            {
                Console.WriteLine(temp + x);

            };
            //在这里对temp值进行更新
            temp = 100;

            //再次进行调用的时候, 会使用最新的temp值.
            variableDelegate(10); 
        }
        static int Test(int n)
        {
            if (n< 0)
            {
                n = 0;
            }

            if (n == 0 || n == 1)
            {
                return n;
            }
            return Test(n - 1) + Test(n - 2);
        }


        static void TeamDelegateTest()
        {
            TeamDelegate teamDelegate = delegate(string name, string[] names)
            {
                Console.WriteLine("队名:" + name);
                Console.WriteLine("队员:");
                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }

            };

            teamDelegate("黄队", "BBB", "小母鸟");
        }

        static void TeamIntroduce(string teamName, params string[] members)
        {
            Console.WriteLine("队名:" + teamName);
            Console.WriteLine("队员:");
            foreach (var item in members)
            {
                Console.WriteLine(item);
            }
        }


        //匿名方法测试
        static void AnoymouseMethodTest()
        {
            NumOperatorDelegate numDel = delegate(int num) 
            {
        
                Console.WriteLine("翻倍");

                return 2 * num;
            };

            numDel += (num) => { return 3 * num; };


            Console.WriteLine(numDel(2));
        }

        //异常委托测试
        static void ExceptionTest()
        {
            ExceptionDelegate exceptionDelegate = ExcptionTest.Method1;
            exceptionDelegate += ExcptionTest.Method2;
            exceptionDelegate += ExcptionTest.Method1;
            exceptionDelegate += ExcptionTest.Method2;



            Delegate[] delegates = exceptionDelegate.GetInvocationList();
            foreach (ExceptionDelegate item in delegates)
            {
                try
                {
                    item();
                }
                catch
                {
                    Console.WriteLine("捕获异常");
                }
            }

            Console.WriteLine("------------");
            for (int i = 0; i < delegates.Length; i++)
            {
                try
                {
                    (delegates[i] as ExceptionDelegate)();
                }
                catch
                {
                    Console.WriteLine("捕获异常");
                }

            }

        }


        // 引用参数委托测试
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
