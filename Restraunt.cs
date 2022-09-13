using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConosoleApp
{
    internal class Files
    {
        public static void Main()
        {
            FileStream fs= new FileStream("C:\\Users\\Satheesh\\Desktop\\New folder\\deserts.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryWriter bw=new BinaryWriter(fs);
            Console.WriteLine("RedVelvet","Brownie","Black ForestCake","WhitwForestCake","RainbowCake");
            bw.Flush();
            fs.Close();
            
            FileStream fs1= new FileStream("C:\\Users\\Satheesh\\Desktop\\New folder\\test.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryReader br=new BinaryReader(fs1);
            
            Console.WriteLine(br.ReadString());
           
           
           
    }
    }   
}