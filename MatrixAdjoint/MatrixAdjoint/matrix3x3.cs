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
    public partial class matrix3x3 : Form
    {
        public matrix3x3()
        {
            InitializeComponent();
        }

        private void matrix3x3_Load(object sender, EventArgs e)
        {

        }

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

            // Ensure negative sign is at the beginning (optional, but good practice)
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Length > 0 && (sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void var1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private double[,] GetMatrix()
        {
            return new double[,]
            { 
                { Convert.ToDouble(row1col1.Text), Convert.ToDouble(row1col2.Text), Convert.ToDouble(row1col3.Text) },
                { Convert.ToDouble(row2col1.Text), Convert.ToDouble(row2col2.Text), Convert.ToDouble(row2col3.Text) },
                { Convert.ToDouble(row3col1.Text), Convert.ToDouble(row3col2.Text), Convert.ToDouble(row3col3.Text) }
            };
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double[,] matrixValues = new double[3, 3];

            matrixValues = GetMatrix();

            cof_11.Text = Convert.ToString(matrixValues[0, 0]);
            cof_12.Text = Convert.ToString(matrixValues[0, 1]);
            cof_13.Text = Convert.ToString(matrixValues[0, 2]);
        }
    }
}
