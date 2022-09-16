using System;

namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cokecount = 0;
            Console.WriteLine("Welcome to the all you can eat buffet. Our buffet is $9.99");
            Console.WriteLine("We have two drink options coke for $2.00 and water.");
            Console.WriteLine("unfortunately we are only taking partys off 5 or less today");
            Console.WriteLine("how many people will we be having today?");
            int customers = Int32.Parse(Console.ReadLine());

            if (customers >= 5) 
            {
                Console.WriteLine("Sorry we can only seat groups of 5 or lower, see you next time");
            }
            else
            {
                Console.WriteLine("what drinks will we be having today");
                String drinks = Console.ReadLine();
                if (drinks == "coke")
                {
                    cokecount++;
                    Console.WriteLine("okay a coke");
                }
                double total = (customers * 9.99) + (cokecount * 2);
                Console.WriteLine("the total is" + total + "have a nice day");




            }
        }
    }
}
