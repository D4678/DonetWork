namespace Ems_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 30);
            label1.Name = "label1";
            label1.Size = new Size(579, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Employee Management System App";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(51, 116);
            button1.Name = "button1";
            button1.Size = new Size(265, 83);
            button1.TabIndex = 1;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(453, 119);
            button2.Name = "button2";
            button2.Size = new Size(299, 80);
            button2.TabIndex = 2;
            button2.Text = "Update Employee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(51, 287);
            button3.Name = "button3";
            button3.Size = new Size(265, 85);
            button3.TabIndex = 3;
            button3.Text = "Delete Employee";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(462, 287);
            button4.Name = "button4";
            button4.Size = new Size(290, 85);
            button4.TabIndex = 4;
            button4.Text = "Display Employee";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(846, 505);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Employee Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
