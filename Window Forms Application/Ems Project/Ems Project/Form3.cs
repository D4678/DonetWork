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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Method to Update employee data into the database
        static void UpdateEmployee(int empId, string email, string mobile, string address)
        {
            string connectionString = "Data Source=DESKTOP-936JTB0;Initial Catalog=EmsDb;Integrated Security=True;Trust Server Certificate=True;";

            string query = "UPDATE Employees SET EmpEmail = @EmpEmail, EmpMobile = @EmpMobile, EmpAddress = @EmpAddress WHERE Empid = @Empid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Empid", empId);
                command.Parameters.AddWithValue("@EmpEmail", email);
                command.Parameters.AddWithValue("@EmpMobile", mobile);
                command.Parameters.AddWithValue("@EmpAddress", address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                       MessageBox.Show("Employee Details Updated SuccessFully");
                    }
                    else
                    {
                        MessageBox.Show("Updation Operation Failed: No Id Found ");
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
            try
            {
                int Empid = int.Parse(textBox1.Text);
                string email = textBox2.Text;
                string mobile = textBox3.Text;
                string address = textBox4.Text;

                UpdateEmployee(Empid, email, mobile, address);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ErrorBlinkStyle" + ex);
            }
        }
    }
}
