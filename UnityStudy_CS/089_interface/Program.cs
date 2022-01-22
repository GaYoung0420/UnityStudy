using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _089_interface
 * DESC: interface 기본
-----------------------------------------------------------------------------*/
namespace _089_interface
{
    interface IAA
    {
        //public int a; //에러..
        //private void IPrint() { } //에러..
        //public void IPrint(); //에러..
        int A { get; set; } //프로퍼티 가능
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("==============================================");
        }
    }

    class AA : IAA
    {
        //인터페이스 사용할 경우 무조건 재정의 해줘야함

        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
    }

    class BB : IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA에 IAAPrint() 재정의");
        }

        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }

    class CC : Super, IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public override void Print() // 선언해도되고 안해도 됨
        {
            base.Print();
            Console.WriteLine("class Super => Print() 재정의");
        }

        public void IAAPrint()
        {
            Console.WriteLine("class CC => interface IAA에 IAAPrint() 재정의");
        }

        public void IBBPrint()
        {
            Console.WriteLine("class CC interface IBB에 IBBPrint() 재정의");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.IAAPrint();

            BB bb = new BB();
            bb.IAAPrint();
            bb.IBBPrint();

            //IAA Iaa = new IAA(); //인스턴스를 생성할 수 없기에 에러 발생
            IAA Iaa = new AA(); //참조 가능
            Iaa.IAAPrint();

            IBB Ibb = bb as IBB; //IBB를 상속받고 IBB로 캐스팅 연산
            Ibb.IBBPrint();

            CC cc = new CC();
            cc.Print();
            cc.IAAPrint();
            cc.IBBPrint();

            Super sCC = cc as Super;
            sCC.Print();

            IAA IAAcc = cc as IAA;
            IAAcc.IAAPrint();

            IBB IBBcc = cc as IBB;
            IBBcc.IBBPrint();
        }
        /*
            class AA interface IAA에 IAAPrint() 재정의
            class BB interface IAA에 IAAPrint() 재정의
            class BB interface IBB에 IBBPrint() 재정의
            class AA interface IAA에 IAAPrint() 재정의
            class BB interface IBB에 IBBPrint() 재정의
            ==============================================
            class Super => Print() 재정의
            class CC => interface IAA에 IAAPrint() 재정의
            class CC interface IBB에 IBBPrint() 재정의
            ==============================================
            class Super => Print() 재정의
            class CC => interface IAA에 IAAPrint() 재정의
            class CC interface IBB에 IBBPrint() 재정의
         */
    }
}