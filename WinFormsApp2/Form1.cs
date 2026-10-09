using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool QiymetOxu(MaskedTextBox xana, out int qiymet)
        {
            string metn = xana.Text.Replace("_", "").Trim();

            return int.TryParse(metn, out qiymet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text.Trim();
            string nomre = maskedTextBox6.Text.Replace("_", "").Trim();

            if (adSoyad == "" || nomre == "")
            {
                MessageBox.Show("Ad, soyad və tələbə nömrəsini daxil edin!");
                return;
            }

            int sdf1, sdf2, ff, seminar, final;

            if (!QiymetOxu(maskedTextBox1, out sdf1) ||
                !QiymetOxu(maskedTextBox2, out sdf2) ||
                !QiymetOxu(maskedTextBox3, out ff) ||
                !QiymetOxu(maskedTextBox4, out seminar) ||
                !QiymetOxu(maskedTextBox5, out final))
            {
                MessageBox.Show("Bütün qiymətləri daxil edin!");
                return;
            }

            if (sdf1 > 10 || sdf2 > 10 || ff > 10 ||
                seminar > 10 || final > 60 ||
                sdf1 < 0 || sdf2 < 0 || ff < 0 ||
                seminar < 0 || final < 0)
            {
                MessageBox.Show(
                    "SDF1, SDF2, FF və Seminar 0-10, " +
                    "Final isə 0-60 arasında olmalıdır!");
                return;
            }

            int netice = sdf1 + sdf2 + ff + seminar + final;

            string kateqoriya;

            if (netice < 34)
                kateqoriya = "D";
            else if (netice <= 50)
                kateqoriya = "C";
            else if (netice <= 70)
                kateqoriya = "B";
            else if (netice <= 90)
                kateqoriya = "A";
            else
                kateqoriya = "A+";

            dataGridView1.Rows.Add(
                adSoyad,
                nomre,
                netice,
                kateqoriya
            );

            MessageBox.Show(
                "Ümumi nəticə: " + netice +
                "\nKateqoriya: " + kateqoriya
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            textBox1.Clear();

            maskedTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
