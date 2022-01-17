using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint03
{
    internal class Program
    {
        const int DELAY_TIME = 300;
        static void UpdateView(char[] tile, int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(tile[map[i, j]]);
                    if (j == map.GetLength(1) - 1)
                        Console.WriteLine();
                }
            }
        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void UpdateGo(int[] arrIndexX, int[,] map)
        {
            for (int i = 0; i < arrIndexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = arrIndexX[i];

                int temp = map[i + 1, indexY];
                map[indexMaxX, indexY + 1] = temp;
                map[indexMaxX, indexY] = 0;

                arrIndexX[i]++;
            }
        }

        static bool UpdateRandomGo(int[] arrIndexX, int[,] map, Random rand)
        {
            bool isFinish = false;
            for (int i = 0; i < arrIndexX.Length; i++)
            {
                if (arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    break;
                }

            }

            int rndIndex = rand.Next(0, 5);
            int indexY = arrIndexX[rndIndex];

            int temp = map[rndIndex + 1, indexY];
            map[rndIndex + 1, indexY + 1] = temp;
            map[rndIndex + 1, indexY] = 0;

            arrIndexX[rndIndex]++;

            return isFinish;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            char[] tile = {' ','-','|','1','2','3','4','5' };
            
            int[,] map = new int[7,22]
            {
               //0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                {4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (true)
            {
                

                UpdateGo(arrIndexX,map);
                isFinish = UpdateRandomGo(arrIndexX, map,rand);

                UpdateView(tile, map);
                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과: {0}번 1등",(i + 1));
                            break;
                        }

                    }
                    Console.Write("\n다시 시작하려면 0을 입력하세요");
                    string inputStr = Console.ReadLine();
                    if(inputStr == "0")
                    {
                        
                        for(int i = 0; i < arrIndexX.Length; i++)
                        {
                            map[i + 1, arrIndexX[i]] = 0;
                            arrIndexX[i] = 0;
                            map[i + 1, 20] = 2;
                            map[i + 1, 0] = 3 + i;
                        }
                        
                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }
                ClearView();
            }
            
        }
    }
}
