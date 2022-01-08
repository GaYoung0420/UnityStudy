using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: _008_Data1
 * DESC: 정수형 데이터 기초
-----------------------------------------------------------------------------*/
namespace _008_Data1
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte a = 120;                  //부호가 있는 8비트 정수
            byte b = 255;                   //부호가 없는 8비트 정수
            short c = 30000;                //부호가 있는 16비트 정수
            long d = 1000000000000000000;   //부호가 있는 64비트 정수
            ulong f = 10000000000000000000; //부호가 없는 64비트 정수
            int num = 100;                  //부호가 있는 32비트 정수

            Console.WriteLine("sbyte a: " + a);
            Console.WriteLine("byte b: " + b);
            Console.WriteLine("short c: " + c);
            Console.WriteLine("long d: " + d);
            Console.WriteLine("long f: " + f);
            Console.WriteLine("int num: " + num);
        }
    }
}
