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

        private void matrix2x2_Load(object sender, EventArgs e)
        {

        }

        // Function for input validation
        private void row1col1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point and negative value
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

        // Function for input validation of variable input
        private void var1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Get Matrix Values
        private double[,] GetMatrix()
        {
            return new double[,]
            {
                { Convert.ToDouble(row1col1.Text), Convert.ToDouble(row1col2.Text) },
                { Convert.ToDouble(row2col1.Text), Convert.ToDouble(row2col2.Text) }
            };
        }

        // Get the Matrix Variable values (letters only)
        private String[] GetMatrixVariable()
        {
            return new String[]
            {
                var1.Text, var2.Text
            };
        }

        // Get the Matrix Result values
        private double[] GetMatrixResult()
        {
            return new double[]
            {
                Convert.ToDouble(result1.Text), Convert.ToDouble(result2.Text)
            };
        }

        // Solve for Cofactor
        private double[,] SolveCofactor(double[,] m)
        {
            return new double[,]
            {
                {  m[1,1], -m[1,0] },
                { -m[0,1],  m[0,0] }
            };
        }

        // Solve for Adjoint
        private double[,] SolveAdjoint(double[,] m)
        {
            return new double[,]
            {
                { m[0,0], m[1,0] },
                { m[0,1], m[1,1] }
            };
        }

        // Solve for Determinant
        private double SolveDeterminant(double[,] m)
        {
            double det = (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);

            if(det == 0)
            {
                MessageBox.Show("Given matrix has no inverse, determinant is 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return det;
        }

        // Solve for Inverse Matrix
        private double[,] SolveInverse(double[,] adj, double det)
        {
            double[,] mInv = new double[2, 2];
            
            for(int i = 0; i < 2; i++)
                for(int j = 0; j < 2; j++)
                    mInv[i,j] = adj[i, j] / det;

            return mInv;
        }

        // Solve the Equation using Matrix Inversion
        private double[] SolveEquation(double[,] inv, double[] mRes)
        {
            double[] solution = new double[2];

            solution[0] = inv[0, 0] * mRes[0] + inv[0, 1] * mRes[1];
            solution[1] = inv[1, 0] * mRes[0] + inv[1, 1] * mRes[1];

            return solution;
        }

        // Print the values in the Cof(A) matrix
        private void DisplayCofactor(double[,] matrixCof)
        {
            cof_11.Text = Convert.ToString(matrixCof[0, 0]);
            cof_12.Text = Convert.ToString(matrixCof[0, 1]);
            cof_21.Text = Convert.ToString(matrixCof[1, 0]);
            cof_22.Text = Convert.ToString(matrixCof[1, 1]);
        }

        // Print the values in the Adj(A) matrix
        private void DisplayAdjoint(double[,] matrixAdj)
        {
            adj_11.Text = Convert.ToString(matrixAdj[0, 0]);
            adj_12.Text = Convert.ToString(matrixAdj[0, 1]);
            adj_21.Text = Convert.ToString(matrixAdj[1, 0]);
            adj_22.Text = Convert.ToString(matrixAdj[1, 1]);
        }

        // Print the inverse matrix
        private void DisplayInverse(double[,] matrixInv)
        {
            inv_11.Text = Convert.ToString(matrixInv[0, 0]);
            inv_12.Text = Convert.ToString(matrixInv[0, 1]);
            inv_21.Text = Convert.ToString(matrixInv[1, 0]);
            inv_22.Text = Convert.ToString(matrixInv[1, 1]);
        }

        // Print the values in the result textbox
        private void DisplaySolution(double[] sol)
        {
            valueResult1.Text = Convert.ToString(sol[0]);
            valueResult2.Text = Convert.ToString(sol[1]);
        }

        private void DisplayVariables(String[] matrixVar)
        {
            varResult1.Text = matrixVar[0];
            varResult2.Text = matrixVar[1];
        }

        // Function to calculate for the solutions
        private void calcButton_Click(object sender, EventArgs e)
        {
            // Initialize arrays
            double[,] matrixValues = new double[2, 2];
            double[] matrixRes = new double[2];
            String[] matrixVar = new String[2];

            double[,] matrixCof = new double[2, 2];
            double[,] matrixAdj = new double[2, 2];
            double[,] matrixInv = new double[2, 2];
            double[] sol = new double[2];
            double determinant;

            // Get the Matrix Values, and solve its Cof(A) and Adj(A)
            matrixValues = GetMatrix();
            matrixVar = GetMatrixVariable();
            matrixRes = GetMatrixResult();

            matrixCof = SolveCofactor(matrixValues);
            matrixAdj = SolveAdjoint(matrixCof);

            // Compute and solve for Determinant
            determinant = SolveDeterminant(matrixValues);
            
            // Solve for inverse
            matrixInv = SolveInverse(matrixAdj, determinant);

            // Solve the linear equation
            sol = SolveEquation(matrixInv, matrixRes);
  
            DisplayCofactor(matrixCof);
            DisplayAdjoint(matrixAdj);
            DisplayInverse(matrixInv);
            DisplayVariables(matrixVar);
            DisplaySolution(sol);

            detTextBox.Text = Convert.ToString(determinant);
        }
    }
}
 