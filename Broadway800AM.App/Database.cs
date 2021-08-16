using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Broadway800AM.App
{
    public class Database
    {
        //public const string ConnectionString = "Data Source=DESKTOP-C25RLDB\\SQLEXPRESS;Initial Catalog=730AM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;

        /// <summary>
        /// step 1 : Define Connection string
        /// step 2 : Create a sql connection object
        /// step 3 : define query
        /// step 4 : create command object
        /// step 5 : execute the command
        /// step 6 : Implement your logic
        /// </summary>

        public static void GetAllPeople()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            var query = "select top 5 id, firstname from tbl";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    var id = result.GetInt32(0);
                    var name = result.GetString(1);
                    Console.WriteLine($"{id}. {name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // private static DataSet ds = new DataSet();

        public static void GetAllPeopleV2()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            var query = "select * from vw_studentparentview";
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);
                var dt = ds.Tables[0];
                var rows = dt.Rows.Count;
                Console.WriteLine($"Student Name \t\t Father Name \t\tMother Name ");
                Console.WriteLine($"----------------------------------------------------------");
                for (int i = 0; i < rows; i++)
                {
                    var StudentName = dt.Rows[i].ItemArray[0];
                    var FatherName = dt.Rows[i].ItemArray[1];
                    var MotherName = dt.Rows[i].ItemArray[2];
                    Console.WriteLine($"{StudentName}\t\t{FatherName}\t\t{MotherName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertData()
        {
            Console.WriteLine("Enter First name");
            var firstname = Console.ReadLine();
            Console.WriteLine("Enter last name");
            var lastname = Console.ReadLine();
            Console.WriteLine("Enter Gender (M/F)");
            var gender = Console.ReadLine();
            Console.WriteLine("Enter Address");
            var address = Console.ReadLine();
            Console.WriteLine("Enter age");
            var age = Console.ReadLine();
            Console.WriteLine("Enter City");
            var city = Console.ReadLine();
            Console.WriteLine("Enter country");
            var country = Console.ReadLine();

            var query = $"insert into tbl (firstname, lastname,gender,address,age,city,country) values ('{firstname}','{lastname}','{gender}','{address}','{age}','{city}','{country}')";

            ExecuteNonQueries(query);
        }

        public static void UpdaeData()
        {
            Console.WriteLine("Enter id");
            var id = Console.ReadLine();
            Console.WriteLine("Enter First name");
            var firstname = Console.ReadLine();
            Console.WriteLine("Enter last name");
            var lastname = Console.ReadLine();
            Console.WriteLine("Enter Gender (M/F)");
            var gender = Console.ReadLine();
            Console.WriteLine("Enter Address");
            var address = Console.ReadLine();
            Console.WriteLine("Enter age");
            var age = Console.ReadLine();
            Console.WriteLine("Enter City");
            var city = Console.ReadLine();
            Console.WriteLine("Enter country");
            var country = Console.ReadLine();

            var query = $"update tbl set firstname='{firstname}', lastname ='{lastname}',gender='{gender}',address='{address}',age='{age}',city='{city}',country='{country}' where id='{id}'";
            ExecuteNonQueries(query);
        }

        public static void DeleteData()
        {
            Console.WriteLine("Enter id");
            var id = Console.ReadLine();
            var query = $"delete from tbl where id='{id}'";
            ExecuteNonQueries(query);
        }

        private static void ExecuteNonQueries(string query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CallStoredProc()
        {
            Console.WriteLine("Enter Student name");
            var studentname = Console.ReadLine();
            Console.WriteLine("Enter Father name");
            var fathername = Console.ReadLine();
            Console.WriteLine("Enter Mother Name");
            var mothername = Console.ReadLine();

            var query = "sp_createStudentParent";

            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@studentname", studentname));
            cmd.Parameters.Add(new SqlParameter("@fathername", fathername));
            cmd.Parameters.Add(new SqlParameter("@mothername", mothername));
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CallStoredProcV2()
        {
            var query = "DemoStroredProc";

            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                adapter.Fill(ds);
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    Console.WriteLine("Table " + i);
                    var dt = ds.Tables[i];
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.Write($"|{dt.Columns[j].ColumnName}\t");
                    }
                    Console.WriteLine();
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        for (int k = 0; k < dt.Columns.Count; k++)
                        {
                            Console.Write("|" + dt.Rows[j].ItemArray[k] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}