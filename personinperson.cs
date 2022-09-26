using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5.sqltask10
{
    internal class personinperson
    {
        public void ShowData()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-GQJ9GIB; database=AdventureWorks2019; user id=sa; password=p@ssword");
            con.Open();
            SqlCommand cmd = new SqlCommand("select BusinessEntityID from Person.password", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
            }
            con.Close();
        }
        public static void Main()
        {
            personinperson dataa1 = new personinperson();
            dataa1.ShowData();
        }

    }
}

