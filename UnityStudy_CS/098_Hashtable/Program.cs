using System;
using System.Collections;

/*-----------------------------------------------------------------------------
 * Name: _098_Hashtable
 * DESC: Hashtable 기본
-----------------------------------------------------------------------------*/
namespace _098_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("pos", 10);
            hashTable.Add("name", "Jack");
            hashTable["weight"] = 10.8f; 

            foreach (object key in hashTable.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTable[key]);
            }

            Console.WriteLine("");

            Hashtable hashTableCopy = new Hashtable()
            {
                ["pos"] = 100,
                ["name"] = "Jane",
                ["weight"] = 100.8f,
            };

            foreach (object key in hashTableCopy.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTableCopy[key]);
            }

        }
        /*
            key: pos, data: 10
            key: weight, data: 10.8
            key: name, data: Jack

            key: pos, data: 100
            key: weight, data: 100.8
            key: name, data: Jane
         */
    }
}