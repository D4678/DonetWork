using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Ems_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        // Method To Delete An employee
        static void DeleteEmployee(int employeeId)
        {
            string connectionString = "Data Source=DESKTOP-936JTB0;Initial Catalog=EmsDb;Integrated Security=True;Trust Server Certificate=True;";

            string query = "DELETE FROM Employees WHERE Empid = @Empid";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@Empid", employeeId);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee Deleted SuccessFully");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Operation Failed: Id is Not Found");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An Error Occured : " + e.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int employeeIdToDelete = int.Parse(textBox1.Text);
            DeleteEmployee(employeeIdToDelete);
        }
    }
}
