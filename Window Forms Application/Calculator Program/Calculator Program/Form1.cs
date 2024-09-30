namespace Calculator_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;

                label4.Text = "Addition Of Two Number : " + result.ToString();
                label4.Visible = true;
                //MessageBox.Show("Addition Of Two Number : " + result);
            }
            else
            {
                MessageBox.Show("Please Fill The Fields");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;

                label4.Text = "Subtraction Of Two Number : " + result.ToString();
                label4.Visible = true;
                //MessageBox.Show("Addition Of Two Number : " + result);
            }
            else
            {
                MessageBox.Show("Please Fill The Fields");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 * num2;

                label4.Text = "Multiply Of Two Number : " + result.ToString();
                label4.Visible = true;
                //MessageBox.Show("Addition Of Two Number : " + result);
            }
            else
            {
                MessageBox.Show("Please Fill The Fields");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 / num2;

                label4.Text = "Division Of Two Number : " + result.ToString();
                label4.Visible = true;
                //MessageBox.Show("Addition Of Two Number : " + result);
            }
            else
            {
                MessageBox.Show("Please Fill The Fields");
            }
        }
    }
}
