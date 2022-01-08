using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _009_Data2
 * DESC: 정수 데이터형의 최소 최대값..
-----------------------------------------------------------------------------*/

namespace _009_Data2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("short min : {0} ~ short max: {1}",short.MaxValue,short.MaxValue);
            Console.WriteLine("byte min : {0} ~ byte max: {1}", byte.MaxValue, byte.MaxValue);
            Console.WriteLine("int min : {0} ~ int max: {1}", int.MaxValue, int.MaxValue);
            Console.WriteLine("long min : {0} ~ long max: {1}", long.MaxValue, long.MaxValue);
        }
        /*
         <Console>
            short min : 32767 ~ short max: 32767
            byte min : 255 ~ byte max: 255
            int min : 2147483647 ~ int max: 2147483647
            long min : 9223372036854775807 ~ long max: 9223372036854775807
         */
    }
}
