using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixAdjoint
{
    public partial class matrix2x2 : Form
    {
        public matrix2x2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void matrix2x2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Function for input validation
        private void row1col1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Function for input validation of variable input
        private void var1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Function to calculate for the solutions
        private void button1_Click(object sender, EventArgs e)
        {
            // Get all text values from the matrix and convert to double
            double r1c1 = Convert.ToDouble(row1col1.Text);
            double r1c2 = Convert.ToDouble(row1col2.Text);
            double r2c1 = Convert.ToDouble(row2col1.Text);
            double r2c2 = Convert.ToDouble(row2col2.Text);

            // Solve for Cofactor [A]
            cof_11.Text = Convert.ToString(r2c2);
            cof_12.Text = Convert.ToString(-1 * r2c1); // r2c1
            cof_21.Text = Convert.ToString(-1 * r1c2); // r1c2
            cof_22.Text = Convert.ToString(r1c1);
        }
    }
}
