// Dealer.cs
// yiheng
// 
// 20192241013
using System;
public class Dealer
{
    private string Name;

    public Dealer(string name)
    {
        Name = name;
    }

    public event Action<string, float> NewGoosArrival;

    //在合适的时候确保有代码来做这件事
    public void NewGoogsArrival(string name, float price)
    {
        Console.WriteLine("{0}上市, 价格{1}", name, price);
        if (NewGoosArrival != null)
        {
            NewGoosArrival(name, price);
        }
    }


}