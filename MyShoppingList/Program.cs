using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Marku\Downloads\samples";
            Console.WriteLine("Enter directory name:");
            string Dir = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine() + ".txt";

            if (Directory.Exists($"{rootDirectory}\\{Dir}") && File.Exists($"{rootDirectory}\\{Dir}\\{fileName}"))
            {
                Console.WriteLine("Directory and file already exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{Dir}");
                File.Create($"{rootDirectory}\\{Dir}\\{fileName}").Close();
            }

            string[] arrayFromFile = File.ReadAllLines($"{rootDirectory}\\{Dir}\\{fileName}");
            List<string> ListOfShopping = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a something to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your things:");
                    string userWish = Console.ReadLine();
                    ListOfShopping.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in ListOfShopping)
            {
                Console.WriteLine($"Your ShoppingList: {wish}");
            }

            File.WriteAllLines($"{rootDirectory}\\{Dir}\\{fileName}", ListOfShopping);
        }
    }
}