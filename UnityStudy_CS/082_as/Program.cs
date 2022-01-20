using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _082_as
 * DESC: as, is키워드 기본
-----------------------------------------------------------------------------*/
namespace _082_as
{
    class Base
    {
        int num;

        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }
    class AA : Base
    {
        int a;

        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }
    }

    class BB : Base
    {
        int b;

        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            //부모 class로 객체를 만든다음 자식 이름으로 객체 생성 가능
            Base aa = new AA();
            aa.Print(); //AA로 객체를 생성했지만 Base이다
            // => Console.WriteLine("aa는 AA의 객체 입니다");

            if (aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체 입니다");
            }
            else if (aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체 입니다");
            }

            Base bb = new BB(); // Base라는 상자 안에 BB 객체를 넣어둠

            BB copyBB = bb as BB; //강제 형 변환
            //박스를 BB로 강제로 캐스팅
            if (null != copyBB) // 원래 BB여서 BB로 바꿀 수 있기 때문에 정상 실행
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("copyBB는 BB객체를 형식 변환!!");
                copyBB.PrintB();
            }

            //AA copyAA = (AA)bb; //예외 상황 발생
            Base copyAA = bb as AA;
            if (null == copyAA) //캐스팅 연산 실패
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("copyAA는 AA객체가 아니므로 null!!");

                copyAA = new AA(); //강제로 새로운 객체 생성
                copyAA.Print();
                //copyAA.PrintA(); //오류(=> 다형성으로 가능)

                AA asAA = copyAA as AA; //강제 형 변환
                asAA.PrintA();
            }

            /*
                num: 0
                num: 0
                aa는 AA의 객체 입니다
                ------------------------------------
                copyBB는 BB객체를 형식 변환!!
                b: 0
                ------------------------------------
                copyAA는 AA객체가 아니므로 null!!
                num: 0
                a: 0
             */
        }
    }
}