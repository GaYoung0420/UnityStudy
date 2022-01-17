using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE_LAB_0118_1
{
    internal class Program
    {
        static float solution(int[] arr)
        {
            int sum = 0;
            float result = 0f;
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1)
                {
                    Console.Write("{0}]",arr[i]);
                }
                else
                {
                    Console.Write(arr[i]+",");
                }
                sum += arr[i];

            }
            result = sum / (float)arr.Length;
            Console.WriteLine();
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******** 1) 평균 구하기 풀이 ********");
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 5, 5 };
            Console.Write("arr1: ");
            Console.WriteLine("arr1 average : {1}", arr1,solution(arr1));
            Console.Write("arr2: ");
            Console.WriteLine("arr2 average : {1}", arr1,solution(arr2));
            
        }
    }
}
