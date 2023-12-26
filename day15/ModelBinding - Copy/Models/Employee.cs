using Microsoft.Data.SqlClient;
using System.Data;

namespace ModelBinding.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic{ get; set; }
        public int DeptNo { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = new List<Employee>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpJuly23;Integrated Security=true";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lstEmps.Add(new Employee
                    {
                        EmpNo = dr.GetInt32("EmpNo"),
                        Name = dr.GetString("Name"),
                        Basic = dr.GetDecimal("Basic"),
                        DeptNo = dr.GetInt32("DeptNo")
                    });
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return lstEmps;
        }
        public static Employee GetEmployee(int EmpNo)
        {
            Employee emp = new Employee();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpJuly23;Integrated Security=true";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employees where EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.EmpNo = dr.GetInt32("EmpNo");
                    emp.Name = dr.GetString("Name");
                    emp.Basic = dr.GetDecimal("Basic");
                    emp.DeptNo = dr.GetInt32("DeptNo");

                }
                else
                    emp = null;
                dr.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }

        public static void Insert(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpJuly23;Integrated Security=true";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static void Update(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpJuly23;Integrated Security=true";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Employees set Name=@Name, basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static void Delete(int EmpNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpJuly23;Integrated Security=true";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

    }
}
