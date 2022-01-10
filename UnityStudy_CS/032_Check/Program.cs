using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _032_Check
 * DESC: GetType()함수로(int,string,float,char)형 CTS표준 출력하기
-----------------------------------------------------------------------------*/

namespace _032_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';
            Console.WriteLine("a: {0}. a.GetType(): {1}", a, a.GetType());
            Console.WriteLine("b: {0}. b.GetType(): {1}", b, b.GetType());
            Console.WriteLine("c: {0}. c.GetType(): {1}", c, c.GetType());
            Console.WriteLine("d: {0}. a.GetType(): {1}", d, d.GetType());
        }
        /*
            a: 100. a.GetType(): System.Int32
            b: AAA. b.GetType(): System.String
            c: 0.123. c.GetType(): System.Single
            d: A. a.GetType(): System.Char
         */
    }
}
