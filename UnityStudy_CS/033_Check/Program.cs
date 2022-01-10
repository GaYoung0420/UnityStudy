using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _033_Check
 * DESC: 간단한 성적 프로그램 만들기
-----------------------------------------------------------------------------*/

namespace _033_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int ko, eng, math, sci, sum;
            float avg;
            Console.Write("국어 점수 입력하세요?");
            temp = Console.ReadLine();
            ko = int.Parse(temp);
            Console.Write("영어 점수 입력하세요?");
            temp = Console.ReadLine();
            eng = int.Parse(temp);
            Console.Write("수학 점수 입력하세요?");
            temp = Console.ReadLine();
            math = int.Parse(temp);
            Console.Write("과학 점수 입력하세요?");
            temp = Console.ReadLine();
            sci = int.Parse(temp);
            sum = ko + eng + math + sci;
            avg = sum / 4.0f;
            Console.WriteLine("국어: {0}  영어: {1} 수학:{2}  과학: {3}", ko, eng, math, sci
                );
            Console.WriteLine("총점: {0}  평균: {1}",sum,avg);
            /*
                국어 점수 입력하세요?75
                영어 점수 입력하세요?80
                수학 점수 입력하세요?45
                과학 점수 입력하세요?90
                국어: 75  영어: 80 수학:45  과학: 90
                총점: 290  평균: 72.5
             */
        }
    }
}
