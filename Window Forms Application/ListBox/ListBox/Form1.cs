namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !=  "")
            {
                FruitsListBox.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Fill The Box");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = FruitsListBox.Items.Count;
            MessageBox.Show("List Items Are : " + count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.RemoveAt(FruitsListBox.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FruitsListBox.Sorted = true;
        }
    }
}
