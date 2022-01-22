using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _090_abstract
 * DESC: abstract기본
-----------------------------------------------------------------------------*/
namespace _090_abstract
{
    abstract class abstractAA //abstract-> 상속을 받기 위해 만들어짐
    {
        public int num;

        public abstractAA(int num) { 
            this.num = num;
        }
        public abstract void abstractPrint(); //강제적으로 상속받은 클래스에서 구현부를 정의..

        public virtual void virtualPrint() //virtual -> 오버라이드 해도되고 안해도 됨
        {
            Console.WriteLine("abstractAA virtual void virtualPrint()");
        }

        public void Print()
        {
            Console.WriteLine("abstractAA Print()");
        }
    }

    class AA : abstractAA
    {
        //AA Class가 생성되는 순간 부모 Class의 생성자 함수를 호출
        //그런데 아무런 처리가 되어있지 않으면 안됌 -> : base(num)
        public AA(int num) : base(num) //int num이 부모 클래스 num으로 넘어간다~
        {
            Console.WriteLine("num: {0}",num);
        }
        //무조건 오버라이드 재정의
        public override void abstractPrint()
        {
            Console.WriteLine("abstractPrint");
        }

        public override void virtualPrint()
        {
            base.virtualPrint();

            Console.WriteLine("override void virtualPrint()");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.abstractPrint();
            aa.virtualPrint();
            aa.Print();

            //abstractAA aa = new AA(); //오류..
        }

        /*
            num: 10
            abstractPrint
            abstractAA virtual void virtualPrint()
            override void virtualPrint()
            abstractAA Print()     
         */
    }
}