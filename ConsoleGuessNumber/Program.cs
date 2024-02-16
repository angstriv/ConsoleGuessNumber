namespace ConsoleGuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎游玩猜数字游戏");
            double answerNumber = 0;

            //用户选择难度
            while (true)
            {
                Console.Write("请选择难度:");
                string dLevel = Console.ReadLine();//用户选择难度
                if (dLevel == "easy")
                {
                    answerNumber = DifficultyLevel.GetEasyNumber();//获取简单数字
                    break;
                }
                else if (dLevel == "medium")
                {
                    answerNumber = DifficultyLevel.GetMediumNumber();//获取中等数字
                    break;
                }
                else if (dLevel == "difficult")
                {
                    answerNumber = DifficultyLevel.GetDifficultNumber();//获取困难数字
                    break;
                }
                else
                {
                    Console.WriteLine("难度错误,请重新输入!");
                    continue;
                }
            }

            //用户开始猜数字
            while (true)
            {
                double inputNumber = 0;//用户输入的数字
                

                //获取用户输入的数字
                while(true)
                {
                    //检测数字是否合法
                    try
                    {
                        Console.Write("请输入想猜的数字:");
                        inputNumber = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("数字不合法");
                        continue;
                    }
                }
                
                //比较2个数
                double difference = inputNumber - answerNumber;
                if (difference > 0)//inputNumber > answerNumbe
                {
                    Console.WriteLine("你输入的大了");
                    continue;

                }
                else if (difference < 0)//inputNumber < answerNumbe
                {
                    Console.WriteLine("你输入的小了");
                    continue;

                }
                else if (difference == 0)
                {
                    Console.WriteLine("恭喜你,猜对了!");
                    break;
                }
            }


            //执行完程序暂停
            Console.Write("按任意键退出...");
            Console.ReadKey();

        }
    }
}
