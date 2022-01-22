using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092_2_CheckPoint
{
    class Army
    {
        //protected : 상속받은 클래스가 참조해서 사용할 수 있는 속성
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void Run()
        {
            Console.Write("{0}의 속도로 ", _Speed);
        }

        public virtual void Attack()
        {
            Console.WriteLine();

            if (this is Healer)
            {
                Console.Write("[마법 공격력 - {0}]으로 ", _Attack * _MP);
            }
            else
            {
                Console.Write("[공격력 - {0}]으로 ", _Attack);
            }
        }
    }

    class Barbarian : Army
    {
        public Barbarian()
        {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;

            Console.WriteLine("Barbarian 생성되었습니다. ");
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("Barbarian 달려갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Barbarian이 칼로 공격!!! ");
        }
    }

    class Giant : Army
    {
        public Giant()
        {
            _HP = 200;
            _MP = 0;
            _Speed = 10;
            _Attack = 200;
            Console.WriteLine("Giant 생성되었습니다. ");
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("Giant 달려갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Giant 공격!!! ");
        }
    }

    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;
            Console.WriteLine("Healer 생성되었습니다. ");
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("Healer 날아갑니다. ", _Speed);
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Healer 마법 공격!!! ");
        }
    }

    class UnitControl 
    {
        public enum UNIT
        {
            NONE,
            BABARIAN,
            GIANT,
            HEALER
        }

        const int MAX = 10;
        Army[] armyArr;
        int indexCount;
        public UnitControl()
        {
            indexCount = 0;
            armyArr = new Army[MAX];
        }
        public string Menu()
        {
            Console.WriteLine(" ++ 유닛 관리 시스템 ++ ");
            Console.WriteLine(" (1)생성   (2)달리기  (3)공격   (0)나가기 ");
            
            return Console.ReadLine();
        }

        public void CreateUnitMenu() 
        {
            Console.Clear();
            Console.WriteLine(" ++ 유닛 생성 ++ ");
            Console.WriteLine(" (1)바바리안   (2)자이언츠  (3)힐러   (0)뒤로가기 ");

            UNIT selectUnit = UNIT.NONE; //처음에는 아무것도 없는 상태에서 받음
            string inputStr = Console.ReadLine();

            if(indexCount >= MAX)
            {
                Console.WriteLine(" ** 유닛 생성 불가 ** ({0}/{1}) ",indexCount,MAX);
                Console.WriteLine();
                return;
            }
            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
                selectUnit = (UNIT)int.Parse(inputStr); //문자열 -> int -> UNIT 캐스팅 연산
            else
                selectUnit = UNIT.NONE;

            switch (selectUnit)
            {
                case UNIT.NONE:
                    indexCount--;
                    break;
                case UNIT.BABARIAN:
                    armyArr[indexCount] = new Barbarian();
                    break;
                case UNIT.GIANT:
                    armyArr[indexCount] = new Giant();
                    break;
                case UNIT.HEALER:
                    armyArr[indexCount] = new Healer();
                    break;
                default:
                    break;
            }

            indexCount++;
        }
        public void unitRunMenu()
        {
            Console.Clear();
            Console.WriteLine(" =======> 유닛 달리기 ");
            Console.WriteLine(" (1)바바리안   (2)자이언츠  (3)힐러    (4)전체 달리기   (0)뒤로가기 ");

            UNIT selectUnit = UNIT.NONE; //처음에는 아무것도 없는 상태에서 받음
            string inputStr = Console.ReadLine();

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selectUnit = (UNIT)int.Parse(inputStr); //문자열 -> int -> UNIT 캐스팅 연산

                UnitRun(selectUnit);
            }else if (inputStr.Equals("4"))
            {
                UnitRun();
            }
            else
            {
                Console.Clear();
            }


        }

        private void UnitRun()
        {
            for (int i = 0; i < indexCount; i++)
            {
                armyArr[i].Run();
            }
        }
        private void UnitRun(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.BABARIAN:
                    for(int i = 0; i < indexCount; i++)
                    {
                        if(armyArr[i] is Barbarian)
                            armyArr[i].Run();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (armyArr[i] is Giant)
                            armyArr[i].Run();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (armyArr[i] is Healer)
                            armyArr[i].Run();
                    }
                    break;
            }
        }

        public void UnitAttackMenu()
        {
            Console.Clear();
            Console.WriteLine(" =======> 유닛 공격 ===> ===> ===>");
            Console.WriteLine(" (1)바바리안   (2)자이언츠  (3)힐러    (4)전체 공격   (0)뒤로가기 ");

            UNIT selectUnit = UNIT.NONE; //처음에는 아무것도 없는 상태에서 받음
            string inputStr = Console.ReadLine();

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selectUnit = (UNIT)int.Parse(inputStr); //문자열 -> int -> UNIT 캐스팅 연산

                UnitAttack(selectUnit);
            }
            else if (inputStr.Equals("4"))
            {
                UnitAttack();
            }
            else
            {
                Console.Clear();
            }


        }

        private void UnitAttack()
        {
            for (int i = 0; i < indexCount; i++)
            {
                armyArr[i].Attack();
            }
        }
        private void UnitAttack(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.BABARIAN:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (armyArr[i] is Barbarian)
                            armyArr[i].Attack();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (armyArr[i] is Giant)
                            armyArr[i].Attack();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (armyArr[i] is Healer)
                            armyArr[i].Attack();
                    }
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UnitControl control = new UnitControl();
            string selectNum;
            bool isLoop = true;

            while (isLoop)
            {
                selectNum = control.Menu();
                switch (selectNum)
                {
                    case "1": //생성
                        control.CreateUnitMenu();
                        break;
                    
                    case "2": //달리기
                        control.unitRunMenu();
                        break;
                    
                    case "3": //공격
                        control.UnitAttackMenu();
                        break;

                    default: //나가기
                        isLoop = false;
                        break;
                }
            }
        }
    }
}
