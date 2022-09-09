using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Calc
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine( num1 + num2);
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
    }
    class Answer : Calc
    {
        public  void mul(int num1, int num2)
        {
            Console.WriteLine(num1 *num2);
        }
        public  void div(int num1, int num2)
        {
             Console.WriteLine(num1 / num2);
        }

    }
    internal class ArithmeticInherit
    {
        public static void Main()
        {
           Answer aobj = new Answer();
            aobj.mul(10,5);
            aobj.div(40,8);
            aobj.add(100,40);
           aobj.sub(75,50);

        }
    }
}