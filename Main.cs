﻿using System;
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
            this.KeyPreview = true;
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            int differenceCount = 0;
            string differences1 = "";
            string differences2 = "";
            if (String.IsNullOrWhiteSpace(text1) || String.IsNullOrWhiteSpace(text2))
            {
                MessageBox.Show("", "ERROR");
                return;
            }

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
            }

            if (differenceCount == 0)
            {
                diffLabel.ForeColor = Color.Green;
                diffLabel.Visible = true;
                diffLabel.Text = "No differences";
            }

            else
            {
                diffLabel.ForeColor = Color.Red;
                diffLabel.Visible = true;
                diffLabel.Text = $"Differences: {differenceCount}";
            }
        }

        private void abtBtn_Click(object sender, EventArgs e)
        {
            if (abtPanel.Visible == false)
            {
                abtBtn.Width = 125;
                abtBtn.Text = "Close About";
                abtPanel.Visible = true;
            }
            else
            {
                abtBtn.Width = 112;
                abtBtn.Text = "About";
                abtPanel.Visible = false;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                abtPanel.Visible = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                compareBtn_Click(this, new EventArgs());
            }
        }
    }
}
