// Alarm.cs
// yiheng
// 
// 20192262312
using System;
public class Alarm
{
    public void Alarming(object sender, TemperatureEventArgs args)
    {
        if (args.temperature >= 95)
        {
            Console.WriteLine("温度上升, 注意安全!");
            if (args.temperature == 100)
            {
                Console.WriteLine("已经烧开拉.");
            }
        }
    }
}