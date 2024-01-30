using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGuessNumber
{
    public static class DifficultyLevel
    {

        public static int GetEasyNumber()//简单难度的数字
        {
            int minValue = RandomNumber.GetIntRandom(1,500);
            int maxValue = RandomNumber.GetIntRandom(500,5000);
            int finalNumber = RandomNumber.GetIntRandom(minValue,maxValue);

            return finalNumber;
        }

        public static double GetMediumNumber()//中等难度的数字
        {
            double minValue = RandomNumber.GetDoubleRandom(1.1, 500.1, 1);
            double maxValue = RandomNumber.GetDoubleRandom(500.1, 5000.1, 1);
            double finalNumber = RandomNumber.GetDoubleRandom(minValue,maxValue, 1);

            return finalNumber;
        }

        public static double GetDifficultNumber()////困难难度的数字
        {
            double minValue = RandomNumber.GetDoubleRandom(1.11, 500.11, 2);
            double maxValue = RandomNumber.GetDoubleRandom(500.11, 5000.11, 2);
            double finalNumber = RandomNumber.GetDoubleRandom(minValue, maxValue, 2);

            return finalNumber;
        }
    }
}
