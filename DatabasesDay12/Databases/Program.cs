using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.ObjectiveC;


namespace Databases
{
    internal class Program
    {
        static void Main()
        {
            // Connect();

            //InsertWithHardCoded();

            //Employees emp = new Employees { EmpNo=115, Name="king", Basic=34595,DeptNo=40 };
            //InsertWithObject(emp);

            //Employees emp = new Employees { EmpNo = 115, Name = "D'Souza", Basic = 34595, DeptNo = 40 };
            //InsertWithParameter(emp);

            //Employees emp = new Employees { EmpNo=119, Name="king", Basic=30000,DeptNo=30 };
            //InsertWithStoredProcedure(emp);

            //SelectSingleValues();

            //DataReader();

            //MultipleDataReader();

            //Employees emp = new Employees {  Name = "king", Basic = 30000, DeptNo = 30, EmpNo = 119 };
            //UpdateWithParameter(emp);

            //Employees emp = new Employees {  Name = "king", Basic = 30000, DeptNo = 30, EmpNo = 119 };
            //UpdateWithStoredProcedure(emp);

            //Employees emp = new Employees {EmpNo = 119 };
            //DeleteWithParameter(emp);

            //Employees emp = new Employees { EmpNo = 117 };
            //DeleteWithStoredprocedure(emp);

        }
        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
           // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            
            try
            {
                cn.Open();

                Console.WriteLine("Success");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { 
                cn.Close();
            }

        }
        static void InsertWithHardCoded()  
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                              //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.ExecuteNonQuery();

                Console.WriteLine(" InsertWithHardCoded Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void InsertWithObject(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";
                cmd.CommandText = $"insert into Employees values({obj.EmpNo},'{obj.Name}',{obj.Basic},{obj.DeptNo})";

                cmd.ExecuteNonQuery();

                Console.WriteLine("InsertWithObject Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void InsertWithParameter(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("InsertWithParameter Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void InsertWithStoredProcedure(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.CommandText = "InsertEmployees";
                cmd.Parameters.AddWithValue("EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("Name", obj.Name);
                cmd.Parameters.AddWithValue("Basic", obj.Basic);
                cmd.Parameters.AddWithValue("DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("InsertWithParameter Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void SelectSingleValues()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;

                //cmd.CommandText = "select Name from Employees where EmpNo=111";
                //cmd.CommandText = "select count(*) from Employees";
                cmd.CommandText = "select * from Employees";


                Object retval = cmd.ExecuteScalar();
                Console.WriteLine(retval);
                Console.WriteLine(" SelectSingleValues Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void DataReader()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "select * from Employees";
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                   // Console.WriteLine(dr[0]);      // with column index
                      //or
                    Console.WriteLine(dr["EmpNo"]); // with column name


                    Employees obj = new Employees();      // with object 

                    obj.EmpNo = (int)dr[0];
                    obj.EmpNo = (int)dr["EmpNo"];

                    obj.EmpNo = dr.GetInt32(0);
                    obj.EmpNo = dr.GetInt32("EmpNo");
                }


                dr.Close();
                Console.WriteLine(" DataReader Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void MultipleDataReader()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "select * from Employees;select * from Departments";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);      // with column index
                    //or
                    Console.WriteLine(dr["EmpNo"]); // with column name


                    Employees obj = new Employees();      // with object 

                    obj.EmpNo = (int)dr[0];
                    obj.EmpNo = (int)dr["EmpNo"];

                    obj.EmpNo = dr.GetInt32(0);
                    obj.EmpNo = dr.GetInt32("EmpNo");
                }
                dr.NextResult();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);      // with column index
                    //or
                    Console.WriteLine(dr["DeptNo"]); // with column name
                    //or
                    Console.WriteLine(dr.GetInt32(0));
                    //or
                    Console.WriteLine(dr.GetInt32("DeptNo"));

                }
                   dr.Close();
                  Console.WriteLine(" DataReader Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void UpdateWithParameter(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.CommandText = "update Employees set Name = @Name,Basic = @Basic,DeptNo = @DeptNo where EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("UpdateWithParameter Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void UpdateWithStoredProcedure(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.CommandText = "UpdateEmployee";
                cmd.Parameters.AddWithValue("Name", obj.Name);
                cmd.Parameters.AddWithValue("Basic", obj.Basic);
                cmd.Parameters.AddWithValue("DeptNo", obj.DeptNo);
                cmd.Parameters.AddWithValue("EmpNo", obj.EmpNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("UpdateWithParameter Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void DeleteWithParameter(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.CommandText = "delete from Employees where EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("DeleteWithParameter Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void DeleteWithStoredprocedure(Employees obj)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // cmd.CommandText = "insert into Employees values(117,'Shubh',12466,20)";

                cmd.CommandText = "DeleteEmployee";
                cmd.Parameters.AddWithValue("EmpNo", obj.EmpNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("DeleteWithStoredParameter Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }



    }
    public class Employees
    {
        public int EmpNo
        {
            set;
            get;
        }
        public string Name
        {
            set;
            get;
        }
        public decimal Basic
        {
            set;
            get;
        }
        public int DeptNo
        {
            set;
            get;
        }
        
        

      
    }
}



namespace Databases2
{
    internal class Program
    {
        static void Main1()
        {
            //Connect();
            Connect2();

           //Employee obj = new Employee { EmpNo = 5, Name = "D'Souza", Basic = 12345, DeptNo = 20 };
           
            MARS();
            //CallDataReaderFunction();
           // Transactions();
        }
        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            //cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;User Id=sa;Password=sa";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Connect2()
        {
            //SqlConnection cn = new SqlConnection();
            ////cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpOct23;User Id=sa;Password=sa";
            //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=true";
            //cn.Open();
            //Console.WriteLine("open");
            //cn.Close();
            using (SqlConnection cn = new SqlConnection())
            {
                //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpOct23;User Id=sa;Password=sa";
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
                cn.Open();
                Console.WriteLine("open");
            }

        }
        static void MARS()        //Multiple Active Result sets
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;MultipleActiveResultSets=true";
            cn.Open();

            //SqlCommand cmdDepts = cn.CreateCommand();

            SqlCommand cmdDepts = new SqlCommand();
            cmdDepts.Connection = cn;
            cmdDepts.CommandType = CommandType.Text;
            cmdDepts.CommandText = "Select * from Departments";

            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = CommandType.Text;

            SqlDataReader drDepts = cmdDepts.ExecuteReader();
            while (drDepts.Read())
            {
                Console.WriteLine((drDepts["DeptName"]));

                cmdEmps.CommandText = "Select * from Employees where DeptNo = " + drDepts["DeptNo"];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    Console.WriteLine(("    " + drEmps["Name"]));
                }
                drEmps.Close();
            }
            drDepts.Close();
            cn.Close();

        }
        static void CallDataReaderFunction()
        {
            SqlDataReader dr = GetDataReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["EmpNo"]);
            }
            dr.Close();
            //if (cn.State == ConnectionState.)
            //Console.WriteLine(cn.State);
        }
        //static SqlConnection cn = new SqlConnection();

        static SqlDataReader GetDataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.Open();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "select * from Employees ";
            //SqlDataReader dr = cmdInsert.ExecuteReader();
            SqlDataReader dr = cmdInsert.ExecuteReader(CommandBehavior.CloseConnection);
            //cn.Close();
            return dr;
        }

        static void Transactions()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.Open();
            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.Transaction = t;

            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into Employees values(10, 'Shweta', 12345, 30)";

            SqlCommand cmdInsert2 = new SqlCommand();
            cmdInsert2.Connection = cn;
            cmdInsert2.Transaction = t;

            cmdInsert2.CommandType = System.Data.CommandType.Text;
            cmdInsert2.CommandText = "insert into Employees values(20, 'Shweta', 12345, 10)";
            try
            {
                cmdInsert.ExecuteNonQuery();
                cmdInsert2.ExecuteNonQuery();
                t.Commit();
                Console.WriteLine("no errors- commit");
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine("Rollback");
                Console.WriteLine(ex.Message);
            }
            cn.Close();

        }


    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}