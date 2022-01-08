using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------
    *Name: _002_HelloWorld2
    *DESC: 메인 함수의 파라미터 보기
 ------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

namespace _002_HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CMD 창을 이용하여 매개변수 입력 해야함
            if(args.Length > 0)
            {
                Console.WriteLine("HelloWorld :     " + args[0]);
            }
            else
            {
                //그냥 빌드하면 해당 결과로 나옴
                Console.WriteLine("HelloWorld : args.Length = 0");
            }
            Console.ReadKey();
        }
    }
}
/*
< CMD 창 >
C:\Users\USER-PC>cd..

C:\Users>cd C:\GaYoung\GitHub\UnityStudy\UnityStudy_CS\002_HelloWorld2\bin\Debug

C:\GaYoung\GitHub\UnityStudy\UnityStudy_CS\002_HelloWorld2\bin\Debug>002_HelloWorld2.exe 10
HelloWorld :     10
 */
