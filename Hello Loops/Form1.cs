using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //  Creates a message box, when you click yes it goes to the while statement, no ends the program
            DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "While", MessageBoxButtons.YesNo);

            //  If the message box got clicked Yes, then this will iterate until they say No
            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's a MessageBox. Do you want another?", "While", MessageBoxButtons.YesNo);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // Iterates through until you click No, then it will exit the Message Box
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < Convert.ToInt32(txtForLoop.Text); m++)  // Iteration from 0 to the user inputed number
            {
                MessageBox.Show("Here's MessageBox " + m + " out of" + Convert.ToInt32(txtForLoop.Text));  // Output on the dialog box every time a new message box pops up
            }
        }
    }
}
