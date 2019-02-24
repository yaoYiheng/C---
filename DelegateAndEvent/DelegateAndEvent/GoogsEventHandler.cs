// GoogsEventHandler.cs
// yiheng
// 
// 20192241113
using System;
public class GoogsEventHandler : EventArgs
{
    public string GoodsName;
    public float GoodsPrice;
    public GoogsEventHandler(string name, float price)
    {
        this.GoodsName = name;
        this.GoodsPrice = price;
    }
}