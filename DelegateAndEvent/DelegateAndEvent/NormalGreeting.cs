using System;
namespace DelegateAndEvent
{
    public class NormalGreeting
    {

        public void MorningiGreeting(string name)
        {
            Console.WriteLine("早上好! " + name);
        }

        public void NightGreeting(string name)
        {
            Console.WriteLine("晚上好! " + name);
        }
    }
}
