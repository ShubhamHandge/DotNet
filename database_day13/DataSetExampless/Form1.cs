using Microsoft.Data.SqlClient;
using System.Data;

namespace DataSetExampless
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
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
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "Emps");

                cmd.CommandText = "select * from Departments";
                da.Fill(ds, "Deps");

                // primary keys
                DataColumn[] arrCols = new DataColumn[1];
                arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
                ds.Tables["Emps"].PrimaryKey = arrCols;

                //foreign key
                ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"], ds.Tables["Emps"].Columns["DeptNo"]);

                //column level constraints
                ds.Tables["Deps"].Columns["DeptName"].Unique = true;



                dataGridView1.DataSource = ds.Tables["Emps"];
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

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";
            cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                SqlCommand cmdUpdate = cn.CreateCommand();
                //or
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                cmdUpdate.CommandType = System.Data.CommandType.Text;
                cmdUpdate.CommandText = "update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";

                //SqlParameter p = new SqlParameter();
                //p.ParameterName = "@Name";
                //p.SourceColumn = "Name";
                //p.SourceVersion = DataRowVersion.Current;
                //cmdUpdate.Parameters.Add(p);

                //or -- simple in row


                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

                SqlCommand cmdDelete = cn.CreateCommand();
                cmdDelete.CommandType = System.Data.CommandType.Text;
                cmdDelete.CommandText = "delete from Employees where EmpNo=@EmpNo";
                cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });


                SqlCommand cmdInsert = cn.CreateCommand();
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });


                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = cmdUpdate;
                da.DeleteCommand = cmdDelete;
                da.InsertCommand = cmdInsert;
                da.Update(ds, "Emps");





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