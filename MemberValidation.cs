using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    internal class Login
    {
        public void UserLogin(string EmailId, string password)
        {
            if (EmailId == "Deepika@gmail.com" && password == "Pswd@678")
            {
                Console.WriteLine("Welcome " + EmailId);
                Console.WriteLine("You are Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Email Id and Password");
            }
        }
        public void UserLogin(int MembershipId, int pin)
        {
            if (MembershipId == 1000 && pin == 0001)
            {
                Console.WriteLine("Welcome " + MembershipId);
                Console.WriteLine("You are  Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Membership Id and pin");
            }

        }
        public void UserLogin(string Mobnumber, int pin)
        {
            if (Mobnumber == "9876543210" && pin == 7865)
            {
                Console.WriteLine("Welcome ", +Mobnumber);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Mobile number and pin");
            }
        }
        public static void Main()
        {
            Login pobj = new Login();
            Console.WriteLine("Enter your Login choice");
            Console.WriteLine("Enter Your EmailID and Password");
            Console.WriteLine("Enter Your for MembershipID and Pin");
            Console.WriteLine("Enter Your Mobile Number and pin");
            int option = Convert.ToInt32(Console.ReadLine());
            string username = "";
            string password = "";
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Your EmailId");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    password = Console.ReadLine();
                    pobj.UserLogin(username, password);
                    break;
                case 2:
                    Console.WriteLine("Enter your MembershipId");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your pin");
                    password = Console.ReadLine();
                    pobj.UserLogin(Convert.ToInt32(username), Convert.ToInt32(password));
                    break;
                case 3:
                    Console.WriteLine("Enter your Mobile Number");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your Pin");
                    password = Console.ReadLine();
                    pobj.UserLogin(username, Convert.ToInt32(password));
                    break;
            }


        }
    }
}