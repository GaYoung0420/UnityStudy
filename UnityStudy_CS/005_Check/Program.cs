using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------
    *Name: _005_Check
    *DESC: 메인 함수 파라미터를 받은 데이터를 사용하기
 ------------------------------------------------------------------------------------------------------------------------------------------------------------------*/


namespace _005_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine("지금 듣는 강의는 " + args[0]);
                Console.WriteLine(args[1] + "좋아요!!");
            }
            else
            {
                Console.WriteLine("입력 없음");
            }
            
        }
    }
}
/*
 < Console >
C:\GaYoung\GitHub\UnityStudy\UnityStudy_CS\005_Check\bin\Debug>005_Check.exe Fastcampus C#
지금 듣는 강의는 Fastcampus
C#좋아요!!
 */