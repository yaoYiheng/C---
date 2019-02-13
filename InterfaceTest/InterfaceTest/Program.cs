using System;
using InterfaceTest.Properties;

namespace InterfaceTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mother mother = new Mother();
            mother.Narrate(new Books());
        }
    }

    class Books : IReader
    {
        public string GetContent()
        {
            return "Once upan a time...";
        }
    }
    class Mother
    {
        public void Narrate(IReader reader)
        {
            Console.WriteLine("开始讲个事");
            Console.WriteLine(reader.GetContent());
        }
    }

}
