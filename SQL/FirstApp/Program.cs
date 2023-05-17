using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SqlConnection con = new SqlConnection("Server=IN-DQ3K9S3; Database=Northwind; Integrated Security=true");
            con.Open();

            while (true)
            {
                Console.WriteLine("Enter table name : ");
                string table = Console.ReadLine();

                Console.WriteLine("Enter search column name : ");
                string column = Console.ReadLine();

                Console.WriteLine("Enter search value : ");
                //int value = Convert.ToInt32(
                string value = Console.ReadLine();

                SqlCommand cmd = new SqlCommand($"select * from {table} where {column} = @pid", con);
                cmd.Parameters.AddWithValue("@pid", value);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine($"{read[0]} | {read[1]} | {read[2]} | {read[3]} | {read[4]} | {read[5]} | {read[6]} | {read[7]} | {read[8]} | {read[9]} ");
                }
                read.Close();
            }
            con.Close();
        }
    }
}