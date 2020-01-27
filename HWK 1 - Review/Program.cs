//Nicholas Wilson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK_1___Review
{
    class Program
    {
        static void Main(string[] args)
        {
            double cogs = 79.99;
            double gears = 250.00;
            double tax = 1.089;
            double smarkup = 1.15;
            double markup = 1.125;
           
            Console.WriteLine("How many cogs do you need for the order? ");
            double cogsq = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many gears do you need for the order? ");
            double gearsq = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("The total cost of the items is: " + ((cogsq * cogs) + (gearsq * gears)).ToString("C2"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("The sales tax amount is: " + (((cogsq * cogs) + (gearsq * gears)) * (tax - 1)).ToString("C2"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("The standard markup is: " + ((cogsq * cogs) + (gearsq * gears) * (smarkup - 1)).ToString("C2"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("The markup for the 10+ or total of 16 price is: " + ((cogsq * cogs) + (gearsq * gears) * (markup - 1)).ToString("C2"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            if (cogs > 10 && gears > 10 || cogs + gears == 16)
            {
                Console.WriteLine("The grand total for markup is: " + (((cogsq * cogs) + (gearsq * gears) * markup) * tax).ToString("C2"));
            }
            else
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("The grand total for standard makrup is: " + (((cogsq * cogs) + (gearsq * gears) * smarkup) * tax).ToString("C2"));
            }


            Console.ReadKey();


        }
    }
}
