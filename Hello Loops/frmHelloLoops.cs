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
    public partial class frmHelloLoops : Form
    {
        public frmHelloLoops()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Writing the code for the While button
            DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "While", MessageBoxButtons.YesNo);
            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's a MessageBox. Do you want another?", "While", MessageBoxButtons.YesNo);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // Writing the code for the DoWhile button
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
                
            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // Writing the code for the For button, in which
            // the user decide the number of MessageBox dialogs
            // to be displayed
        
            decimal numberOfDialogBoxes;
            numberOfDialogBoxes = numDialogBoxes.Value;
            for (decimal m = 1; m <= numberOfDialogBoxes; m++)
            {
                MessageBox.Show("Here's MessageBox " + m );
            }
        }
    }
}
