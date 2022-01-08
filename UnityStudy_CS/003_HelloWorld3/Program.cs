using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------
    *Name: _003_HelloWorld3
    *DESC: 다양한 형태의 메인 함수
 ------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

namespace _003_HelloWorld3
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("static void Main(string[] args)");
        //}
        // > static void Main(string[] args)

        //static void Main()
        //{
        //   Console.WriteLine("static void Main");
        //}

        //static int Main()
        //{
        //    Console.WriteLine("static int Main");
        //    return 0;
        //}

        static int Main(string[] args)
        {
            Console.WriteLine("AAA{0} BBB{1}",1,"aa");
            Console.Write("{0}{1}{2}", 2, 3, 1);
            Console.WriteLine("static int Main(string[] args)");
            return 0;
            /*
             < Console >
             AAA1 BBBaa
             231static int Main(string[] args)
             */
        }
    }
}
