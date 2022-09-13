using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAge
{
    internal class MemberInitialize
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public MemberInitialize()
        {
        }
        public MemberInitialize(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    public class  Member
    {
        public static void Main()
        {
            MemberInitialize memberInitialize = new MemberInitialize { Name = "Deepika", Age = 23 };
            MemberInitialize member = new MemberInitialize("Deepika", 23);
            
        }
    }
}

