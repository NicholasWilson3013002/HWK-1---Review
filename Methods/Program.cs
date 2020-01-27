using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void LineValueForY()
        {
            Console.WriteLine("Parameter M: ");
            double parameterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Parameter X: ");
            double parameterx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Parameter B: ");
            double parameterb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Slope of this line is: " + ((parameterm * parameterx) + (parameterb)));

            Console.ReadKey();
        }

        static void Factorial()
        {
            int number;
            
            

            Console.WriteLine("Enter any number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = number - 1; i >= 1; i--)
            {
                 number = number * i;
            }
            Console.WriteLine("Factorial of given input: " + number);
            Console.ReadKey();
        }




        static void Main(string[] args)
        {
            
            LineValueForY();
            Factorial();
            

            Console.ReadLine();
        }
        
       
    }
}
