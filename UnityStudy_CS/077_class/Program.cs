using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _077_class
 * DESC: 클래스 기본
-----------------------------------------------------------------------------*/
namespace _077_class
{
    class AA
    {
        //멤버 변수..
        int num1; //기본적으로 private 속성
        public int num2, num3;

        //멤버 함수..
        public void Print()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }

        private void PrintPrivate()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            //aa.num1 = 10; // 오류
            aa.num2 = 100; //public 속성만 접근 가능
            aa.num3 = 1000;

            aa.Print();
            //aa.PrintPrivate(); //오류
        }
    }
}