using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            int differenceCount = 0;
            string differences1 = "";
            string differences2 = "";

            progressBar1.Maximum = Math.Max(text1.Length, text2.Length);
            progressBar1.Value = 0;

            for (int i = 0; i < Math.Min(text1.Length, text2.Length); i++)
            {
                if (text1[i] != text2[i])
                {
                    differenceCount++;
                    differences1 += $"{text1[i]} ";
                    differences2 += $"{text2[i]} ";
                }
                else
                {
                    differences1 += "  ";
                    differences2 += "  ";
                }
                progressBar1.Value++;
            }
            progressBar1.Value = 100;
            textBox3.Text = differences1;
            textBox4.Text = differences2;

            if (differenceCount == 0)
            {
                diffLabel.Visible = true;
                diffLabel.Text = "No differences";
            }

            else
            {
                diffLabel.Visible = true;
                diffLabel.Text = $"Differences: {differenceCount}";
            }
            progressBar1.Value = 0;
        }

    }
}
