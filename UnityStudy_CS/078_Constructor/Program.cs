using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _078_Constructor
 * DESC: 클래스 생성자, 소멸자
-----------------------------------------------------------------------------*/
namespace _078_Constructor
{
    class AA
    {
        //멤버변수
        int a;
        float b;

        //생성자
        //비워서 선언하더라도 무조건 생성자 함수 제공해야함
        public AA()
        {
            a = 0;
            b = 0f;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
            Console.WriteLine("  b: {0}", b);
        }
        //오버라이딩
        public AA(int _a)
        {
            a = _a;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
            Console.WriteLine("  b: {0}", b);
        }
        public AA(int _a, float _f = 0.0f)
        {
            a = _a;
            b = _f;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
            Console.WriteLine("  b: {0}", b);
        }
        
        //소멸자,매개변수X, 자동으로 불러와짐
        ~AA()
        {
            Console.WriteLine("  Call Destructor  ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA aaa = new AA(10);
            AA aaaa = new AA(100, 0.5f);
        }
    }
}