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
            // Initialize the form components
            InitializeComponent();
            // Set the KeyPreview property to true to allow the form
            // to receive key events before any other control on the form
            this.KeyPreview = true;
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            // Get the text from the two text boxes
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            // Initialize a variable to count the number of differences between the two texts
            int differenceCount = 0;

            // Check if either of the text boxes is empty or contains only whitespace
            if (String.IsNullOrWhiteSpace(text1) || String.IsNullOrWhiteSpace(text2))
            {
                // If either of the text boxes is empty or contains only whitespace,
                // display an error message to the user and return from the method
                // without performing the comparison
                MessageBox.Show("None of the inputs can be left empty.\nPlease fill them up before proceeding.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Iterate through each character in both texts and check if they are equal
            for (int i = 0; i < Math.Min(text1.Length, text2.Length); i++)
            {
                if (text1[i] != text2[i])
                    differenceCount++;
            }

            // Check if there are any differences between the two texts
            if (differenceCount == 0)
            {
                // If there are no differences, set the ForeColor property of
                // the diffLabel control to green and set its Text property to "No differences"
                diffLabel.ForeColor = Color.Green;
                diffLabel.Visible = true;
                diffLabel.Text = "No differences";
            }
            else
            {
                // If there are differences, set the ForeColor property of the diffLabel control
                // to red and set its Text property to show the number of differences
                diffLabel.ForeColor = Color.Red;
                diffLabel.Visible = true;
                diffLabel.Text = $"Differences: {differenceCount}";
            }
        }

        private void abtBtn_Click(object sender, EventArgs e)
        {
            // Check if the abtPanel control is visible
            if (abtPanel.Visible == false)
            {
                // If it is not visible, set its Visible property to true
                // and change the Text property of the abtBtn control to "Close About"
                abtBtn.Width = 125;
                abtBtn.Text = "Close About";
                abtPanel.Visible = true;
            }
            else
            {
                // If it is visible, set its Visible property to false
                // and change the Text property of the abtBtn control back to "About"
                abtBtn.Width = 112;
                abtBtn.Text = "About";
                abtPanel.Visible = false;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the user pressed the Esc key on their keyboard
            if (e.KeyCode == Keys.Escape)
            {
                // If they did, set the Visible property of the abtPanel control to
                // false and change the Text property of the abtBtn control back to "About"
                abtBtn.Width = 112;
                abtBtn.Text = "About";
                abtPanel.Visible = false;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Clear the text in both text boxes and hide the diffLabel control
            textBox1.Text = "";
            textBox2.Text = "";
            diffLabel.Visible = false;
        }
    }
}
