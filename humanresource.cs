using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp5.sqltask10
{
    internal class humanresource
    {
        public void insData(int BusinessEntityID, DateTime date, UniqueId rowguid)
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-GQJ9GIB; database=AdventureWorks2019; user id=sa; password=p@ssword");
            SqlCommand cmd = new SqlCommand("sp_person.password", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusinessEntityID", SqlDbType.Int).Value =BusinessEntityID;
            cmd.Parameters.AddWithValue("@modifiedDate", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@rowguid", SqlDbType.UniqueIdentifier).Value = rowguid;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted");

        }
        public static void Main()
        {
            Dataa1 dataa1 = new Dataa1();

            dataa1.insData( "101",DateTime.Now, "329EACBE-C883-4F48-B8B6-17AA4627EFFF5676");
        }
    }
}
