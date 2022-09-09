

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class JaggedArray
{
    static void Main()
    {
        
       string[][] arr = new string[3][];

        
         arr[0] = new string[4] { "\tBiscuit :" ,"\tmilk" ,"\tcookies" ,"\tOreo" };
        
         arr[1] = new string[4] { "\nChocolates:"," \tkitkat", "\tdairymilk", "\tlollypop" };
         arr[2] = new string[4] { "\nDrinks:"," cola", "\tbovonto", "\tmaaza" };

for (int i = 0; i < arr.Length; i++)
       {
           for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.Write( arr[i][j], j == (arr[i].Length - 0) ? "" : " ");
            
             
            
            }
           
       }
        
    }
}