using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            _Dictionary<string, int> dictionary = new _Dictionary<string, int>();
            Dictionary<string, int> dictionary1 = new Dictionary<string, int>();
            dictionary.Add("Hello", 10);
            dictionary.Add("happy", 12);
            dictionary.Add("year", 1);

            int s = dictionary["happy"];


            //foreach (var item in dictionary)
            //{

            //}
            Console.WriteLine();
        }
    }
}
