using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Mary");

            Console.WriteLine(names.Length);

            names.Add("Jessica");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

        }
    }
}