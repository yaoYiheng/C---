// NumJudge.cs
// yiheng
// 
// 20192132058
using System;
public class NumJudge
{
    /// <summary>
    /// 判断是否为质数
    /// </summary>
    public static bool PrimeJudge(int num)
    {
        for (int i = 2; i < num - 1; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 判断是否是偶数
    /// </summary>
    /// <returns><c>true</c>, if judeg was evened, <c>false</c> otherwise.</returns>
    /// <param name="num">Number.</param>
    public static bool EvenJudeg(int num)
    {
        return (num % 2 == 0);
    }

    /// <summary>
    ///   判断目标整数是否是2的整数次幂
    /// </summary>
    /// <returns><c>true</c>, if judge was exponented, <c>false</c> otherwise.</returns>
    /// <param name="num">Number.</param>
    public static bool ExponentJudge(int num)
    {
        return (num & (num - 1)) == 0;
    }

}
