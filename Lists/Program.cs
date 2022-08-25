using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lists = new List<string>();

            Console.WriteLine(Lists.Count);

            Lists.Add("coffee machine");
            Lists.Add("new pair of socks");
            Lists.Add("box of chocolates");
            Lists.Add("new pillow");

            Console.WriteLine(Lists.Count);

            foreach (string wish in Lists)
            {
                Console.WriteLine(wish);
            }
        }
    }
}