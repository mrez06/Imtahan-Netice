namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            maskedTextBox6 = new MaskedTextBox();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            Catagory = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 100);
            panel1.TabIndex = 0;
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 100);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(462, 33);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 1;
            label1.Text = "Imtahan Sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 136);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Sdf1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 214);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Sdf2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 293);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "FF";
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 372);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Seminar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 444);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 5;
            label6.Text = "Final";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(163, 136);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(163, 214);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(163, 293);
            maskedTextBox3.Mask = "00000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 8;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(163, 372);
            maskedTextBox4.Mask = "00000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 9;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(163, 444);
            maskedTextBox5.Mask = "00000";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 10;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(maskedTextBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(294, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 331);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Telebe Melumatlari";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(6, 191);
            button2.Name = "button2";
            button2.Size = new Size(243, 35);
            button2.TabIndex = 14;
            button2.Text = "Xanalari sifirla";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 150);
            button1.Name = "button1";
            button1.Size = new Size(243, 35);
            button1.TabIndex = 13;
            button1.Text = "Hesabla";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 86);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 12;
            label7.Text = "Telebe nomresi";
            
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(6, 108);
            maskedTextBox6.Mask = "000000000";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(243, 23);
            maskedTextBox6.TabIndex = 12;
            maskedTextBox6.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 55);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ad Soyad";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 0;
            
            // 
            // button3
            // 
            button3.Location = new Point(1109, 507);
            button3.Name = "button3";
            button3.Size = new Size(114, 35);
            button3.TabIndex = 15;
            button3.Text = "Cixis";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FullName, Number, Result, Catagory });
            dataGridView1.Location = new Point(602, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 331);
            dataGridView1.TabIndex = 16;
            // 
            // FullName
            // 
            FullName.HeaderText = "Ad ve Soyad";
            FullName.Name = "FullName";
            // 
            // Number
            // 
            Number.HeaderText = "Telebe Nomresi";
            Number.Name = "Number";
            // 
            // Result
            // 
            Result.HeaderText = "Netice";
            Result.Name = "Result";
            // 
            // Catagory
            // 
            Catagory.HeaderText = "Katagoriya";
            Catagory.Name = "Catagory";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1235, 572);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label7;
        private MaskedTextBox maskedTextBox6;
        private Button button2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn Catagory;
    }
}
