using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE_LAB_0118_3
{
   
    internal class Program
    {
         public int[] solution(int[] arr, int[,] commands)
        {
            int[] result = new int[] { };


            return result;
        }
        static void printArray(int[] arr)
        {
            Console.Write("array: [");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    Console.WriteLine(arr[i] + "]");
                else
                    Console.Write(arr[i] + ",");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******** 3) K번째수 ********");
            int[] arr = { 1, 5, 2, 6, 3, 7, 4 };
            printArray(arr);
        }
    }
}
