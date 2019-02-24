// Client.cs
// yiheng
// 
// 2019224108
using System;
public class Client
{
    private string Name;

    public Client(string name)
    {
        this.Name = name;
    }

    public void GetGoodsInfo(string name, float price)
    {
        Console.WriteLine("{0}得到{1}的价格为{2}", this.Name, name, price);
    }
}
