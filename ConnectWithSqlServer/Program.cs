using System;
using System.Data.SqlClient;

namespace ConnectWithSqlServer
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().CreateTable();
            //new Program().InsertIntoTable();
            new Program().RetriveFromTable();
        }
        //public void CreateTable()
        //{
        //    SqlConnection con = null;
        //    // Creating Connection 
        //    con = new SqlConnection(@"Data Source=GAURI\SQLEXPRESS; Initial Catalog=EmployeeHDR; Integrated Security=True");
        //    //string query = "drop table EmpHdr";
        //    // writing sql query  
        //    string query = "Create table EmpHdr(id int not null, name varchar(100), email varchar(50), join_date date)";
        //    SqlCommand cm = new SqlCommand(query, con);
        //    try
        //    {
        //        con.Open();
        //        cm.ExecuteNonQuery();
        //        Console.WriteLine("Table created Successfully");
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine("OOPs, something went wrong." + e);
        //    }
        //    finally
        //    {

        //        con.Close();
        //        Console.ReadKey();
        //    }
        //}

        //public void InsertIntoTable()
        //{
        //    SqlConnection con = null;
        //    con = new SqlConnection(@"Data Source=GAURI\SQLEXPRESS; Initial Catalog=EmployeeHDR; Integrated Security=True");
        //    string query = "Insert into EmpHdr values(101,'Gauri', 'Gauri22@gmail.com',convert(date,getDate()))";
        //    SqlCommand cm = new SqlCommand(query, con);
        //    try
        //    {
        //        con.Open();
        //        cm.ExecuteNonQuery();
        //        Console.WriteLine("Record inserted successfully!");
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine("OOPs, something went wrong." + e);
        //    }
        //    finally
        //    {
        //        con.Close();
        //        Console.ReadKey();
        //    }
        //}


        public void RetriveFromTable()
        {
            SqlConnection con = null;
            con = new SqlConnection(@"Data Source=GAURI\SQLEXPRESS; Initial Catalog=EmployeeHDR; Integrated Security=True");
            string query = "select * from EmpHdr";
            SqlCommand cm = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"] + " " + sdr["join_date"]);
                }
                //Console.WriteLine("Record Retrived successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

    }
}
