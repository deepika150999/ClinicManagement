using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractArithmetic
{
    public class AddSubtract
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("\nSum of given numbers is {0}\n",a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("\nDifference of given numbers is {0}\n",a-b);
        }

    }
    public class MultiplyDivide:AddSubtract
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine("\nProduct of given numbers is {0}\n",a*b);
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine("\nDivision of given numbers is {0}\n",a/b);
        }
    }

    public class ArithmeticOperations
    {
        public static void Main()
        {
            Console.WriteLine("Enter Two Numbers");
            int a= Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            AddSubtract addSubtract = new AddSubtract();
            addSubtract.Add(a,b);
            addSubtract.Sub(a,b);
            MultiplyDivide muldiv = new MultiplyDivide();
            muldiv.Multiply(a,b);
            muldiv.Divide(a,b);
        }
    }
}

