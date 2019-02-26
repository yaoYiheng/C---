// Heater.cs
// yiheng
// 
// 20192262252
using System;
using System.Timers;

public class TemperatureEventArgs : EventArgs
{
    public int temperature;

    public TemperatureEventArgs(int temp)
    {
        this.temperature = temp;
    }
}

public class Heater
{
    private int temperature;
    private Timer timer;

    //作为事件的发布者, 需要声明委托类型以及事件
    public delegate void HeaterDelegate(object sengder, TemperatureEventArgs tempArg);

    public event EventHandler<TemperatureEventArgs> OnHeatHandler;
    //事件声明
    public event HeaterDelegate HeaterHandler;

    public Heater(int temper)
    {
        this.temperature = temper;
        timer = new Timer(1000);
    }

    private void BoilWater(object sender, ElapsedEventArgs e)
    {
        temperature++;

        if (temperature >= 100)
        {
            timer.Stop();
        }

        //对温度进行封装
        TemperatureEventArgs args = new TemperatureEventArgs(temperature);
        if (HeaterHandler != null)
        {
            HeaterHandler(this, args);
        }

        if (OnHeatHandler != null)
        {
            OnHeatHandler(this, args);
        }

    }

    public void StartHeating()
    {
        //将需要调用到计时器的方法之策到事件上.
        timer.Elapsed += BoilWater;
        //开始计时.
        timer.Start();
    }
}