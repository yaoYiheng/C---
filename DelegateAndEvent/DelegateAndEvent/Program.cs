using System;

namespace DelegateAndEvent
{
    //声明delegate
    public delegate void GreetingDelegate (string name);
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NormalGreeting normalGreeting = new NormalGreeting();

            GreetingDelegate greeting1 = new GreetingDelegate(normalGreeting.MorningiGreeting);

            GreetingDelegate greeting2 = FestivalGreeting.XmasGreeting;

        }
    }
}
