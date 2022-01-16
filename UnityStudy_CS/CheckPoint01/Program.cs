using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string LINE = "--------------------------------------------";
            const int END_LINE = 42;
            int sleepNum = 200;
            int runA = 0, runB = 0, runC = 0, runD = 0;
            Random random = new Random();

            while (true) 
            {
                Thread.Sleep(sleepNum); //딜레이
                Console.Clear(); //화면지우기

                ++runA;
                ++runB;
                ++runC;
                ++runD; 

                int rndNum = random.Next(0,4); //0 ~ 3
                int runRndNum = random.Next(0, 2);

                switch (rndNum)
                {
                    case 0:
                        runA += runRndNum;
                        break;
                    case 1:
                        runB += runRndNum;
                        break;
                    case 2:
                        runC += runRndNum;
                        break;
                    case 3:
                        runD += runRndNum;
                        break;
                }

                Console.WriteLine(LINE);
                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.Write("1");
                for (int i = (END_LINE-1) - runA; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");


                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.Write("2");
                for (int i = (END_LINE - 1) - runB; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.Write("3");
                for (int i = (END_LINE - 1) - runC; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.Write("4");
                for (int i = (END_LINE - 1) - runD; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");


                Console.WriteLine(LINE);
                if (runA >= END_LINE ||
                    runB >= END_LINE ||
                    runC >= END_LINE ||
                    runD >= END_LINE )
                {
                    string result = "결과 :  !!{0}번 선수 우승!!";
                    int strNum = 0;

                    if (runA >= END_LINE)
                        strNum = 1;
                    else if (runB >= END_LINE)
                        strNum = 2;
                    else if (runC >= END_LINE)
                        strNum = 3;
                    else
                        strNum = 4;

                    Console.WriteLine(result, strNum);
                    Console.Write("다시하려면 0번 입력:  ");
                    if("0" == Console.ReadLine())
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;
                    }
                }
            }
            
        }
    }
}
