using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPrees
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }
        int n, m;
        string F = "";
        string B = "";
        string F2 = "";
        string B2 = "";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F = "";
            B = "";
            F2 = "";
            B2 = "";
            shaqiriw();
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void shaqiriw()
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(numericUpDown1.Text);

            for (int i = 0; i < n / 2; i += 2)
            {
                F += n - i + ",";
                F += m + i + ",";
            }
            for (int i = 0; i < n / 2; i += 2)
            {
                B += n / 2 - i + ",";
                B += n / 2 + 1 + i + ",";
            }
            for (int i = 0; i < n / 2; i += 2)
            {
                F2 += n - i + ",";
                F2 += m + i + ",";
            }
            /* for (int i = 0; i < n / 2; i += 2)
             {
                 B2 += n / 2 - i - 2 + ",";
                 B2 += n / 4 + 1 + i + 2 + ",";
             }*/
            if (n % 8 == 0)
            {
                for (int i = (m + n / 2 - 3), j = m + n / 2 + 2, k = m + n / 2 - 1, l = m + n / 2; (i >= m - 1) && (j <= m + n - 2) && (k >= m + 3) && (l <= m + n - 4); i = i - 4, j = j + 4, k = k - 4, l = l + 4)
                {
                    B2 += i + ",";
                    B2 += j + ",";
                    B2 += k + ",";
                    if (l == (m + n - 4))
                        B2 += l.ToString();
                    else
                        B2 += l + ",";
                }
            }
            textBox2.Text = F;
            textBox3.Text = B;
            textBox4.Text = F2;
            textBox5.Text = B2;
        }
    }
}
