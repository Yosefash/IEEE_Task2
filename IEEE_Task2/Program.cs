using System;
using System.Runtime.InteropServices;

namespace IEEE_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contect TheListOfContect = new Contect();
            bool s = true;
             do
             {
                Console.WriteLine("1. Add Contect");
                Console.WriteLine("2. Edit Contect");
                Console.WriteLine("3. Delete Contect");
                Console.WriteLine("4. Shoe All Contects");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                Console.Write("Enter Your Choice : ");
                Console.WriteLine("");
                int Option = int.Parse(Console.ReadLine());
                if (Option == 1)
                {
                    TheListOfContect.AddContect();
                }
                else if (Option == 2)
                {
                    TheListOfContect.Edit();
                }
                else if (Option == 3)
                {
                    TheListOfContect.RemoveContect();
                }
                else if (Option == 4)
                {
                    TheListOfContect.ShowAllContects();
                }
                else
                {
                    s = false;
                }
             } while (s);
        }
    }
}
