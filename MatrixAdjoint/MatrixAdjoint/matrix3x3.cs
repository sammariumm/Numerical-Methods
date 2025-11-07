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

        // Check inputs
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

        // Get the values of the Matrix from each textbox
        private double[,] GetMatrix()
        {
            return new double[,]
            { 
                { Convert.ToDouble(row1col1.Text), Convert.ToDouble(row1col2.Text), Convert.ToDouble(row1col3.Text) },
                { Convert.ToDouble(row2col1.Text), Convert.ToDouble(row2col2.Text), Convert.ToDouble(row2col3.Text) },
                { Convert.ToDouble(row3col1.Text), Convert.ToDouble(row3col2.Text), Convert.ToDouble(row3col3.Text) }
            };
        }

        // Get the resulting values of the matrix from each textbox
        private double[] GetMatrixResult()
        {
            return new double[]
            { 
                Convert.ToDouble(result1.Text), Convert.ToDouble(result2.Text), Convert.ToDouble(result3.Text) 
            };
        }

        // Get the given variables of the matrix from each textbox
        private String[] GetMatrixVariables()
        {
            return new String[]
            {
                var1.Text, var2.Text, var3.Text
            };
        }

        /*
         * Solve for the Determinant using Basket Method
         * @param m Matrix input
         */
        private double SolveDeterminant(double[,] m)
        {
            double det = (
                            (m[0,0] * m[1,1] * m[2,2]) + 
                            (m[0,1] * m[1,2] * m[2,0]) + 
                            (m[0,2] * m[1,0] * m[2,1])
                          ) -
                          (
                            (m[0,2] * m[1,1] * m[2,0]) +
                            (m[0,0] * m[1,2] * m[2,1]) +
                            (m[0,1] * m[1,0] * m[2,2])
                          );

            if (det == 0)
            {
                MessageBox.Show("Given matrix has no inverse, determinant is 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return det;
        }

        private double[,] SolveCofactor(double[,] m)
        {
            double[,] res = new double[3,3];

            res[0, 0] = (m[1,1] * m[2,2]) - (m[1,2] * m[2,1]);
            res[0, 1] = (m[1,0] * m[2,2]) - (m[1,2] * m[2,0]);
            res[0, 2] = (m[1,0] * m[2,1]) - (m[1,1] * m[2,0]);

            res[1, 0] = (m[0,1] * m[2,2]) - (m[0,2] * m[2,1]);
            res[1, 1] = (m[0,0] * m[2,2]) - (m[0,2] * m[2,0]);
            res[1, 2] = (m[0,0] * m[2,1]) - (m[0,1] * m[2,0]);

            res[2, 0] = (m[0,1] * m[1,2]) - (m[0,2] * m[1,1]);
            res[2, 1] = (m[0,0] * m[1,2]) - (m[0,2] * m[1,0]);
            res[2, 2] = (m[0,0] * m[1,1]) - (m[0,1] * m[1,0]);
            
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if ((i + j) % 2 != 0)
                       res[i, j] = -res[i, j];

            return res;
        }

        private double[,] SolveAdjoint(double[,] m)
        {
            return new double[,]
            {
                { m[0,0], m[1,0], m[2,0] },
                { m[0,1], m[1,1], m[2,1] },
                { m[0,2], m[1,2], m[2,2] }
            };
        }

        private double[,] SolveInverse(double[,] m, double det)
        {
            double[,] mInv = new double[3, 3];

            for(int i = 0; i < 3;i++)
                for(int j = 0; j < 3; j++)
                    mInv[i,j] = m[i,j] / det;

            return mInv;
        }

        private double[] SolveEquation(double[,] mInv, double[] mRes)
        {
            double[,] solutionInitial = new double[3, 3];
            double[] solution = { 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                solutionInitial[i, 0] = mInv[i, 0] * mRes[0];
                solutionInitial[i, 1] = mInv[i, 1] * mRes[1];
                solutionInitial[i, 2] = mInv[i, 2] * mRes[2];
            }

            for(int i = 0; i < 3; i++)
            {
                solution[0] += solutionInitial[0, i];
                solution[1] += solutionInitial[1, i];
                solution[2] += solutionInitial[2, i];
            }

            return solution;
        }

        private void DisplayCofactor(double[,] matrixCof)
        {
            cof_11.Text = Convert.ToString(matrixCof[0, 0]);
            cof_12.Text = Convert.ToString(matrixCof[0, 1]);
            cof_13.Text = Convert.ToString(matrixCof[0, 2]);

            cof_21.Text = Convert.ToString(matrixCof[1, 0]);
            cof_22.Text = Convert.ToString(matrixCof[1, 1]);
            cof_23.Text = Convert.ToString(matrixCof[1, 2]);

            cof_31.Text = Convert.ToString(matrixCof[2, 0]);
            cof_32.Text = Convert.ToString(matrixCof[2, 1]);
            cof_33.Text = Convert.ToString(matrixCof[2, 2]);
        }

        private void DisplayAdjoint(double[,] matrixAdj)
        {
            adj_11.Text = Convert.ToString(matrixAdj[0, 0]);
            adj_12.Text = Convert.ToString(matrixAdj[0, 1]);
            adj_13.Text = Convert.ToString(matrixAdj[0, 2]);

            adj_21.Text = Convert.ToString(matrixAdj[1, 0]);
            adj_22.Text = Convert.ToString(matrixAdj[1, 1]);
            adj_23.Text = Convert.ToString(matrixAdj[1, 2]);

            adj_31.Text = Convert.ToString(matrixAdj[2, 0]);
            adj_32.Text = Convert.ToString(matrixAdj[2, 1]);
            adj_33.Text = Convert.ToString(matrixAdj[2, 2]);
        }

        private void DisplayInverse(double[,] matrixInv)
        {
            inv_11.Text = Convert.ToString(matrixInv[0, 0]);
            inv_12.Text = Convert.ToString(matrixInv[0, 1]);
            inv_13.Text = Convert.ToString(matrixInv[0, 2]);

            inv_21.Text = Convert.ToString(matrixInv[1, 0]);
            inv_22.Text = Convert.ToString(matrixInv[1, 1]);
            inv_23.Text = Convert.ToString(matrixInv[1, 2]);

            inv_31.Text = Convert.ToString(matrixInv[2, 0]);
            inv_32.Text = Convert.ToString(matrixInv[2, 1]);
            inv_33.Text = Convert.ToString(matrixInv[2, 2]);
        }

        private void DisplaySolution(double[] sol)
        {
            valueResult1.Text = Convert.ToString(sol[0]);
            valueResult2.Text = Convert.ToString(sol[1]);
            valueResult3.Text = Convert.ToString(sol[2]);
        }

        private void DisplayVariables(String[] matrixVar)
        {
            varResult1.Text = matrixVar[0];
            varResult2.Text = matrixVar[1];
            varResult3.Text = matrixVar[2];
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double[,] matrixValues = new double[3, 3];
            double[] matrixRes = new double[3];
            String[] matrixVar = new String[3];
            double[,] matrixCof = new double[3, 3];
            double[,] matrixAdj = new double[3, 3];
            double[,] matrixInv = new double[3, 3];
            double[] sol = new double[3];
 
            double determinant;

            matrixValues = GetMatrix();
            matrixRes = GetMatrixResult();
            matrixVar = GetMatrixVariables();

            matrixCof = SolveCofactor(matrixValues);
            matrixAdj = SolveAdjoint(matrixCof);
            determinant = SolveDeterminant(matrixValues);
            matrixInv = SolveInverse(matrixAdj, determinant);
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
