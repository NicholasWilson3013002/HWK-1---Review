using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which item would you like to buy? Apples, Oranges, Bananas, Grapes, or BLueberries");
            string answer = Convert.ToString(Console.ReadLine());


            string[] fruit = new string[5] { "Apples", "Oranges", "Bananas", "Grapes", "Blueberries" };

            double[] price = new double[5] { 0.99, 0.50, 0.50, 2.99, 1.99 };

            if (answer = fruit)
            {
                Console.WriteLine("The fruit is " + fruit + "and the price is: " + price);
            }





            Console.ReadKey();
            

        }
    }
}
