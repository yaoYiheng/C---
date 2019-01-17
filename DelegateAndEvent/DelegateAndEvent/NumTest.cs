using System;
namespace DelegateAndEvent
{
    public class NumTest
    {
        public static int NumTest1()
        {
            Console.WriteLine("int void 1调用");
            return 10;
        }
        public static int NumTest2()
        {
            Console.WriteLine("int void 2调用");
            return 20;
        }
    }

    public class NumOprator
    {
        public static int NumInCreaseTest1(int num)
        {
            Console.WriteLine("自增调用");
            num++;
            return num;
        }
        public static int NumDecreaseTest2(int num)
        {
            Console.WriteLine("自减调用");

            num--;
            return num;
        }
        public static int NumDouble(int num)
        {
            Console.WriteLine("2倍调用");
            return 2 * num;
        }
    }

    public class NumRef
    {
        public static int NumRefTest1(ref int num)
        {
            Console.WriteLine("自增调用");
            num++;
            return num;
        }
        public static int NumRefTest2(ref int num)
        {
            Console.WriteLine("自减调用");

            num--;
            return num;
        }
    }
}
