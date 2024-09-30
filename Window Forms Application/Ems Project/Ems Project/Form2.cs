using Microsoft.Data.SqlClient;


namespace Ems_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Method to insert employee data into the database
        private void InsertEmployee(int empId, string firstName, string lastName, string mobile, string email, string address)
        {
            
            string connectionString = "Data Source=DESKTOP-936JTB0;Initial Catalog=EmsDb;Integrated Security=True;Trust Server Certificate=True;";

           
            string query = "INSERT INTO Employees (Empid, EmpFirstName, EmpLastName, EmpMobile, EmpEmail, EmpAddress) " +
                           "VALUES (@Empid, @EmpFirstName, @EmpLastName, @EmpMobile, @EmpEmail, @EmpAddress)";

           
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                
                cmd.Parameters.AddWithValue("@Empid", empId);
                cmd.Parameters.AddWithValue("@EmpFirstName", firstName);
                cmd.Parameters.AddWithValue("@EmpLastName", lastName);
                cmd.Parameters.AddWithValue("@EmpMobile", mobile);
                cmd.Parameters.AddWithValue("@EmpEmail", email);
                cmd.Parameters.AddWithValue("@EmpAddress", address);

                try
                {
                   
                    con.Open();

                    // Execute the query to insert the data
                    int rowsAffected = cmd.ExecuteNonQuery();

                   
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the employee.");
                    }
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {       
           
            if(textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                int empId = Convert.ToInt32(textBox1.Text);
                string firstName = textBox2.Text;
                string lastName = textBox3.Text;
                string email = textBox4.Text;
                string mobile = textBox5.Text;
                string address = textBox6.Text;
                InsertEmployee(empId, firstName, lastName, mobile, email, address);
            }
            else
            {
                MessageBox.Show("Fill All The Fields");
            }

        }
    }
}
