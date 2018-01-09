using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algebra1
{
    public partial class Form1 : Form
    {

        Exercise exercise;
        public Form1()
        {
            exercise = new Exercise();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long number;
            long Result;
            try
            {
                number = long.Parse(txtNumber.Text);
                Result = exercise.Factorial(number);
                txtFactorial.Text = Result.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCalcPermutation_Click(object sender, EventArgs e)
        {
            long n;
            long r;
            long Result;
            try
            {
                n = long.Parse(txtPermutationN.Text);
                r = long.Parse(txtPermutationR.Text);
                Result = exercise.Permutation(n,r);
                txtPermutation.Text = Result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        private void btnCalcCombination_Click(object sender, EventArgs e)
        {
            long n;
            long r;
            long Result;
            try
            {
                n = long.Parse(txtCombinationN.Text);
                r = long.Parse(txtPermutationR.Text);
                Result = exercise.Combinatorial(n, r);
                txtCombination.Text = Result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
