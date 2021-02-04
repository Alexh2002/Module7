using System;
using System.Collections;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myTable = new Hashtable();

            myTable[1] = "my string";
            myTable["super key"] = 123;
            myTable["123"] = false;

            myTable.Add(123456, 9);

            bool doesItContainIt = myTable.Contains(1);

            bool doesItContainThis = myTable.ContainsKey(1);

            bool doesItContain = myTable.ContainsValue(1);




            //Console.WriteLine(myTable["123"])

            foreach (DictionaryEntry item in myTable)
            {
                Console.WriteLine("The key is: " + item.Key + "The value is: " + item.Value);
            }
        }
    }
}
