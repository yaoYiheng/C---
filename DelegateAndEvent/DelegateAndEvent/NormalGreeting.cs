using System;
namespace DelegateAndEvent
{
    public class NormalGreeting
    {

        private GreetingDelegate greetingDelegate;

        public event GreetingDelegate GreetingEvent
        {
            add
            {
                greetingDelegate = Delegate.Combine(greetingDelegate, value) as GreetingDelegate;
            }
            remove
            {
                greetingDelegate = Delegate.Remove(greetingDelegate, value) as GreetingDelegate;
            }

        }


        public void MorningiGreeting(string name)
        {
            Console.WriteLine("早上好! " + name);
        }

        public void NightGreeting(string name)
        {
            Console.WriteLine("晚上好! " + name);
        }

        public void DoingGreeting(string name)
        {
            if (greetingDelegate != null)
            {
                greetingDelegate(name);
            }
        }

        public void Init()
        {
            greetingDelegate = (name) => { Console.WriteLine("你好" + name); };
            GreetingEvent += NightGreeting;
            GreetingEvent += MorningiGreeting;
            greetingDelegate("xiaoM");
        }
    }
}
