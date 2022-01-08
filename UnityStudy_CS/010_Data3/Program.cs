using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _010_Data3
 * DESC: 데이터 형태 오류
-----------------------------------------------------------------------------*/

namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData; //캐스트 연산오류
            int num = (int)sbyteData; //캐스팅 연산 자동으로 해줌

            Console.WriteLine("sbyteData: " + sbyteData);
            Console.WriteLine("sbyteData2: " + sbyteData2);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
            Console.WriteLine("num: " + num);
            Console.WriteLine("int.MaxValue: " + int.MaxValue);
            /*
             sbyteData: 255
             sbyteData2: -1 //캐스트 연산오류
             sbyte.MaxValue: 127 //저장하고자 하는 값이 더 크기에 연산 오류 남
             num: 255
             int.MaxValue: 2147483647
             */
        }
    }
}
