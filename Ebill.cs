using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Ebill
    {
        public static void Main()
        {
            Console.WriteLine("Enter the units");
            int units = Convert.ToInt32(Console.ReadLine());
            if (units<=200)
                Console.WriteLine(units*2);
            else if (units>=201 && units<=350)
            {
                int value = units-200;
                Console.WriteLine("the value is{0}",400+value*3);


            }
           else if (units>=351 && units<=500)
            {
                int val = units-350;
                Console.WriteLine("the value is{0}",850+val*5);

            }
        else if(units>=501)
            {
                int value2 = units-500;
                Console.WriteLine("the value is{0}",1600+value2*7);
            }

        }
    }
}
