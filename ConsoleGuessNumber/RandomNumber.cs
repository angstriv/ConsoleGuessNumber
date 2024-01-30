using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGuessNumber
{
    public static class RandomNumber
    {

        /// <summary>
        /// 生成一个整数类型的随机数
        /// </summary>
        /// <param name="minValue">起始值</param>
        /// <param name="maxValue">最终值</param>
        /// <returns></returns>
        public static int GetIntRandom(int minValue, int maxValue)
        {
            Random ran = new Random();
            
            int number = ran.Next(minValue, maxValue);
            return number;
        }

        /// <summary>
        /// 生成一个小数类型的随机数
        /// </summary>
        /// <param name="minValue">起始值</param>
        /// <param name="maxValue">最终值</param>
        /// <param name="decimalPlace">保留几位小数</param>
        /// <returns></returns>
        public static double GetDoubleRandom(double minValue, double maxValue, int decimalPlace)
        {
            Random ran = new Random();

            double randNum = ran.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNum.ToString("f" + decimalPlace));
        }
    }
}
