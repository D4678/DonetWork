﻿namespace ListBox
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
            FruitsListBox = new System.Windows.Forms.ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // FruitsListBox
            // 
            FruitsListBox.FormattingEnabled = true;
            FruitsListBox.Items.AddRange(new object[] { "Banana", "Mango", "Orange", "Grapes", "Papaya", "KIwi", "Apple", "Watermelon", "Melon", "Cheery" });
            FruitsListBox.Location = new Point(13, 8);
            FruitsListBox.Name = "FruitsListBox";
            FruitsListBox.Size = new Size(170, 424);
            FruitsListBox.TabIndex = 0;
            FruitsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 26);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 1;
            label1.Text = "Add Items";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(429, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(445, 103);
            button1.Name = "button1";
            button1.Size = new Size(234, 47);
            button1.TabIndex = 3;
            button1.Text = "Add Items";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(445, 184);
            button2.Name = "button2";
            button2.Size = new Size(234, 40);
            button2.TabIndex = 4;
            button2.Text = "Count";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(445, 250);
            button3.Name = "button3";
            button3.Size = new Size(231, 46);
            button3.TabIndex = 5;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(448, 318);
            button4.Name = "button4";
            button4.Size = new Size(228, 44);
            button4.TabIndex = 6;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(449, 395);
            button5.Name = "button5";
            button5.Size = new Size(230, 37);
            button5.TabIndex = 7;
            button5.Text = "Sort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(FruitsListBox);
            Name = "Form1";
            Text = "ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox FruitsListBox;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
