using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 22;
            
            int c = a & b;
            Console.WriteLine("a & b: " + c);

            int d = a | b;
            Console.WriteLine("a | b: " + d);

            int e = a ^ b;
            Console.WriteLine("a ^ b: " + e);

            int f = a << 2;
            Console.WriteLine("a << 2: " + f);
            Console.WriteLine("a << 1: " + (a << 1)); //왼쪽으로 1시프트 2배 증가(곱셈연산)

            int g = 20 >> 2;
            Console.WriteLine("20 >. 2: " + g);
            Console.WriteLine("20 >> 1: " + (20 >> 1)); //오른쪽으로 1시프트하면 2로 나눔(나눗셈 연산)

            int h = ~b;
            Console.WriteLine("h = ~b: " + h);

            int i = (~b) >> 2;
            Console.WriteLine("i = (~b) >> 2: " + i);

            string s = Convert.ToString(a,2).PadLeft(32,'0');
            Console.WriteLine("s: " + s);
            s = Convert.ToString(b,2).PadLeft(32,'0');

        }
        /*
            a & b: 6
            a | b: 31
            a ^ b: 25
            a << 2: 60
            a << 1: 30
            20 >. 2: 5
            20 >> 1: 10
            h = ~b: -23
            i = (~b) >> 2: -6
            s: 00000000000000000000000000001111
         
         
         */
    }
}
