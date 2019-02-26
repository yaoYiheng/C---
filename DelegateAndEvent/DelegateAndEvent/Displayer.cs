// Displayer.cs
// yiheng
// 
// 2019226231
using System;
public class Displayer
{
    public void ShowTemperatuer(object sengder, TemperatureEventArgs tempArg)
    {
        Console.WriteLine("当前温度为" + tempArg.temperature);
    }
}