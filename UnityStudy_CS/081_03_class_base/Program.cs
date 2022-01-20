using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _081_03_class_base
 * DESC: 클래스 상속에서 생성자와 소멸자..
-----------------------------------------------------------------------------*/
namespace _081_03_class_base
{
    class Super
    {
        int num;
        protected string name;

        public Super(int num)
        {
            this.num = num;
        }

        public void PrintSuper()
        {
            Console.WriteLine("Super  num: {0} ", num);
        }
    }

    class Sub : Super
    {
        string name;
        //부모의 생성자에 매개변수를 무조건 받기 때문에
        //base를 이용하여 매개변수를 받아야함
        public Sub(int num, string name) : base(num)
        {
            this.name = name;
        }

        public void PrintSub()
        {
            base.name = "Super";
            base.PrintSuper();

            Console.WriteLine("Super  name: {0}", base.name);
            Console.WriteLine("Sub  name: {0}", this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(26, "Jack");
            sub.PrintSub();
        }
        /*
            Super  num: 26
            Super  name: Super
            Sub  name: Jack
         */
    }
}