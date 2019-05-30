using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP5202Lists1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("==================================================");
            Console.WriteLine("================= Lists!! Wooo!! =================");
            Console.WriteLine("==================================================\n");

            //Exercise 1
            List<string> animal = new List<string>();

            animal.Add("Siberian Wolf");
            animal.Add("Komodo Dragon");
            animal.Add("Brown Bear");
            animal.Add("White Bengal Tiger");
            animal.Add("Kuro Manx");

            Console.WriteLine("===== List of Animals =====");

            for(int index = 0; index < animal.Count; index++)
            {
                Console.WriteLine(animal[index]);
            }

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
            Console.Clear();

            //Exercise 2

            Console.WriteLine("==================================================");
            Console.WriteLine("================== More Lists!! ==================");
            Console.WriteLine("==================================================\n");

            List<string> names = new List<string>();
            bool loop = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter a name: ");
                names.Add(Console.ReadLine());

                Console.WriteLine("Would you like to add another name to the list? (Y/N): ");
                string result = Console.ReadLine() .ToLower();

                if (result == "n")
                    loop = false;
            } while (loop);

            Console.WriteLine("Names you have entered: ");
            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
