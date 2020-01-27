using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops


    

{
    class Program
    {
        static void Main(string[] args)
        {
            int examgrade1 = 0;


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please input exam grade: ");
                examgrade1 += Convert.ToInt32(Console.ReadLine());
              
            }

            Console.Write("The average is: " + (examgrade1 / 3).ToString());
            
            Console.ReadKey();
            
        }
    }
}
