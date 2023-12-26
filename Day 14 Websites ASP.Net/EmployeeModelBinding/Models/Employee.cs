using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using System.Data;

namespace EmployeeModelBinding.Models
{
    public class Employee
    {

        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo {  get; set; }


        public static void InsertWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
           // Data Source = (localdb)\ProjectModels; Initial Catalog = YcpOct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @" Data Source = (localdb)\ProjectModels; Initial Catalog = YcpOct23; Integrated Security = True;";
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
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


        public static Employee GetSingleEmployee(int EmpNo)
        {
            Employee obj = new Employee();
            //
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @" Data Source = (localdb)\ProjectModels; Initial Catalog = YcpOct23; Integrated Security = True;";
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                //dr.HasRows
                if (dr.Read())
                {
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");

                }
                else
                    obj = null;
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            //
            return obj;
        }

       
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = new List<Employee>();
            //
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @" Data Source = (localdb)\ProjectModels; Initial Catalog = YcpOct23; Integrated Security = True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee obj = new Employee();
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");
                    lstEmps.Add(obj);

                    //lstEmps.Add(new Employee { EmpNo = dr.GetInt32("EmpNo") })
                }
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            //
            return lstEmps;
        }


        public static void UpdateWithParam(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @" Data Source = (localdb)\ProjectModels; Initial Catalog = YcpOct23; Integrated Security = True;";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "insert into Employees values(112, 'Navjyot Paaji', 21345, 20)";
                cmd.CommandText = $"update Employees set Name = @Name,Basic = @Basic,DeptNo = @DeptNo where EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("Name", obj.Name);
                cmd.Parameters.AddWithValue("Basic", obj.Basic);
                cmd.Parameters.AddWithValue("DeptNo", obj.DeptNo);
                cmd.Parameters.AddWithValue("EmpNo", obj.EmpNo);

                cmd.ExecuteNonQuery();

                Console.WriteLine("UpdateWithParam success");
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
        public static void DeleteWithParam(int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @" Data Source = (localdb)\ProjectModels; Initial Catalog = YcpOct23; Integrated Security = True;";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "insert into Employees values(112, 'Navjyot Paaji', 21345, 20)";
                cmd.CommandText = $"delete Employees where EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("EmpNo", id);

                cmd.ExecuteNonQuery();

                Console.WriteLine("DeleteWithParam success");
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
}
