using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE_LAB_0118_3
{
   
    internal class Program
    {
         static int[] solution(int[] arr, int[,] commands)
        {
            int[] result = new int[commands.GetLength(0)];

            for(int i = 0; i < commands.GetLength(0); i++)
            {
                int first = commands[i, 0] -1;
                int last = commands[i, 1] -1;
                int index = commands[i, 2] -1;
                int[] temp = new int[(last - first)+1];
                // Array.Copy(a, 1, b, 0, 3);
                // a = 소스 배열, 1 = 소스 배열에서 인덱스 시작, b = 대상 배열, 0 = 대상 배열의 시작 색인, 3 = 복사 할 요소
                Array.Copy(arr, first, temp, 0, last - first + 1);
                Array.Sort(temp);
                printArray(temp);
                result[i] = temp[index];
            }

            return result;
        }
        static void printArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    Console.Write(arr[i] + "]");
                else
                    Console.Write(arr[i] + ",");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******** 3) K번째수 ********");
            int[] arr = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3}, { 4, 4, 1}, { 1, 7, 3} };
            Console.Write("array: ");
            printArray(arr);
            Console.WriteLine();
            Console.Write("commands: ");
            int[] result = solution(arr, commands);
            Console.WriteLine();
            Console.Write("result array: ");
            printArray(result);
            Console.WriteLine();

        }
    }
}
