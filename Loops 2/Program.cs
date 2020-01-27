using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Yes";

            double examgrade = 0;


            int result = 0;

            while (input != "No")
            {
                Console.WriteLine("What is your exam grade? ");
                examgrade += Convert.ToDouble(Console.ReadLine());
                result += 1;



                Console.WriteLine("Enter another grade? Y/N ");
                input = Convert.ToString(Console.ReadLine());
            }



            Console.WriteLine("Average Score: " + (examgrade / result));

            Console.ReadKey();
        }
    }
}
