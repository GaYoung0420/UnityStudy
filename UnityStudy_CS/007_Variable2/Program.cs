using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _007_Variable2
 * DESC: 변수 선언에 다양한 방법..
-----------------------------------------------------------------------------*/
namespace _007_Variable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100; //선언과 동시에 초기화
            int y = 200;
            int a = 1000, b = 2000, c;

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            c = 500;
            Console.WriteLine(c);
        }
        /*
         <Console>
            x: 100
            y: 200
            a: 1000
            b: 2000
            500
         */
    }
}