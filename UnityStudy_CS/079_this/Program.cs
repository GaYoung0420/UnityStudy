using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _079_this
 * DESC: this키워드: 객체 자신을 참조하는 키워드
-----------------------------------------------------------------------------*/
namespace _079_this
{
    class AA
    {
        int a; //private

        public AA(int a) //int a = 10;
        {
            this.a = a;
        }

        public void Print()
        {
            int a = 100;
            this.a = 1000;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("this.a: {0}", this.a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            AA aa = new AA(10);
            aa.Print();
        }
        /*
            a: 100
            this.a: 1000
         */
    }
}