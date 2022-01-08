using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using : 선언된 네임스페이스 내부 개체들에 접근
// System에 있는 것을 가져다가 쓰겠다

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------
    *Name: _001_HelloWorld
    *DESC: 코드 리뷰
 ------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
namespace _001_HelloWorld
// namespace : 그룹화, 동일한 함수의 이름 사용 가능
{
    //class : 필드(field),메소드(method)로 분리, 프로그램을 구성하는 기본
    internal class Program
    {
        static void Main(string[] args)
        {
            //콘솔 출력
            Console.WriteLine("HelloWorld");
            // == System.Console.WriteLine("HelloWorld");
        }
    }
}
