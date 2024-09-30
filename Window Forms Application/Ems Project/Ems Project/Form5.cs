using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ems_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void BindGrid()
        {
            string constring = "Data Source=DESKTOP-936JTB0;Initial Catalog=EmsDb;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT * FROM Employees";  
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MessageBox.Show("Clicked value: ");
        }

    }
}
