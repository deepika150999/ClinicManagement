using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract class Winner
    {
        public abstract void Medal();
    }
    class Gold :Winner
    {
        public void First()
        {
            Console.WriteLine("5 Days Accomadation at resort");
        }
        public override void Medal()
        {
            Console.WriteLine(" 2 Dinners on house"); 
        }
    }
    class Sliver : Winner
    {
        public void Second()
        {
            Console.WriteLine("3 Days Accomadation at resort");
        }
        public override void Medal()
        {
           
        }
    }
    class Bronze : Winner
    {
        public void Third()
        {
            Console.WriteLine("7 Days Accomadation at resort");
        }
        public override void Medal()
        {
            Console.WriteLine("5 Dinners on house");
        }
    }
    
   internal class Abstact
    {
        public static void Main()
        {
            Gold gold = new Gold();
            gold.First();
gold.Medal();
Sliver sliver = new Sliver();
sliver.Second();
sliver.Medal();

Bronze bronze =new Bronze();
bronze.Third();
bronze.Medal();
           
        }
      }
  }

      
