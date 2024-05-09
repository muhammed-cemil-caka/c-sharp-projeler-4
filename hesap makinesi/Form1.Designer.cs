namespace hesap_makinesi
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 176);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 0;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "sayı1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "sayı2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 275);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "toplam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 317);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "fark";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 361);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 5;
            label5.Text = "çarpım";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 403);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "bölüm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 275);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 13;
            label7.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 317);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 14;
            label8.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(194, 361);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 15;
            label9.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(194, 403);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 16;
            label10.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}