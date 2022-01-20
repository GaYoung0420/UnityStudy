using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _083_override
 * DESC: 오버라이딩(다형성): 
 * 같은 기능을 하는 함수를 오버라이딩해서 다른 기능을 추가적으로 할 수 있음
-----------------------------------------------------------------------------*/
namespace _083_override
{
    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("num:  {0}", num);
        }
    }

    class AA : Super
    {
        public int a;
        public override void Print() //오버라이딩해서 재정의
        {
            //기본적으로 재정의 할때
            //기존에 가지고 있던 base 클래스에 있는 메소드를 먼저 실행하고
            //새로 재정의한 코드를 넣도록 함
            base.Print(); //없어도 가능
            Console.WriteLine("AA a:  {0}", a);
        }
    }

    class BB : Super
    {
        public int b;

        public override void Print()
        {
            base.Print();
            Console.WriteLine("BB b:  {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            super.Print();

            //Super라는 이름으로 여러개를 만들었는데 서로 다른 객체로 만들어짐
            Super aa = new AA();
            aa.Print();
            //-> Super의 Print() -> virtual 속성 -> override 속성의 재정의 함수 실행

            Super bb = new BB();
            bb.Print();
        }
        /*
            num:  0
            num:  0
            AA a:  0
            num:  0
            BB b:  0
         */
    }
}