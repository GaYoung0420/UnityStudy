using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE_LAB_0118_2
{
    internal class Program
    {
        static int solution(int input)
        {
            int result = 0;

            while(input > 0)
            {
                result += (input % 10);
                input /= 10;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******** 2) 자릿수 더하기 ********");

            while (true)
            {
                Console.Write("자연수 입력: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("끝");
                    break;
                }
                Console.WriteLine("자릿수 덧셈 결과 : "+ solution(num));
            }
            

        }
    }
}
