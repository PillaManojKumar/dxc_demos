using System.Data.SqlClient;
using System.Data;

namespace DisconnectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection con = new SqlConnection("Server=IN-DQ3K9S3; database=Northwind; Integrated Security=true");
            //SqlDataAdapter adp = new SqlDataAdapter("Select * from Customers", con);
            //DataSet ds = new DataSet();
            //adp.Fill(ds, "CustTable");
            //for (int i = 0; i < ds.Tables["CustTable"].Rows.Count; i++)
            //{
            //    for (int j = 0; j < ds.Tables["CustTable"].Columns.Count; j++)
            //    {
            //        Console.Write($"{ds.Tables["CustTable"].Rows[i][j]} | ");
            //    }
            //    Console.WriteLine();
            //}
            //SqlDataAdapter adp2 = new SqlDataAdapter("Select * from Products", con);
            //adp2.Fill(ds, "ProductTable");
            //Console.WriteLine(ds.Tables.Count);


            SqlConnection con = new SqlConnection("Server=IN-DQ3K9S3; database=Cust; Integrated Security=true");
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Cust", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            var row = ds.Tables[0].NewRow();
            row["CustId"] = 2;
            row["CustName"] = "Manoj";
            row["City"] = "Goa";
            row["Pincode"] = 535501;

            ds.Tables[0].Rows.Add(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            adp.Update(ds);
            Console.WriteLine("Database Updated");
        }
    }
}