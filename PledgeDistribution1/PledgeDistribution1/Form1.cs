using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PledgeDistribution1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMessage.Text = "";
        }

        private void CalculatePledgeAmount()
        {
            double AmountPledge = 0;
            double RateAmount1 = 0;
            double RateAmount2 = 0;
            double RateAmount3 = 0;
            double Amount1 = 0;
            double Amount2 = 0;
            double Amount3 = 0;
            double Rest = 0;
            double TotalAmount = 0;

            try
            {
                AmountPledge = double.Parse(txtAmountPledged.Text);
                RateAmount1 = (double)updAmount1.Value;
                RateAmount2 = (double)updAmount2.Value;
                RateAmount3 = (double)updAmount3.Value;

                Amount1 = (AmountPledge * RateAmount1) / 100;
                Amount2 = (AmountPledge * RateAmount2) / 100;
                Amount3 = (AmountPledge * RateAmount3) / 100;
                Rest = AmountPledge - Amount1 - Amount2 - Amount3;
                TotalAmount = Amount1 + Amount2 + Amount3;

                if (Rest > 0 && Rest < AmountPledge)
                {
                    lblMessage.Text = "Short: "+Rest.ToString("C");
                }
                else if (TotalAmount > AmountPledge)
                {
                    lblMessage.Text = "Excess: "+(TotalAmount-AmountPledge).ToString("C");
                }
                else
                {
                    lblMessage.Text = "";
                }
                

                txtAmount1.Text = Amount1.ToString("F");
                txtAmount2.Text = Amount2.ToString("F");
                txtAmount3.Text = Amount3.ToString("F");
            }
            catch
            {
                MessageBox.Show("The amount you entered is not valid");
            }
        }

        private void CalculatePledgeRate()
        {
            double AmountPledge = 0;
            double RateAmount1 = 0;
            double RateAmount2 = 0;
            double RateAmount3 = 0;
            double Amount1 = 0;
            double Amount2 = 0;
            double Amount3 = 0;
            double Rest = 0;

            try
            {
                AmountPledge = double.Parse(txtAmountPledged.Text);
                Amount1 = double.Parse(txtAmount1.Text);
                Amount2 = double.Parse(txtAmount2.Text);
                Amount3 = double.Parse(txtAmount3.Text);

                RateAmount1 = (100 * Amount1) / AmountPledge;
                RateAmount2 = (100 * Amount2) / AmountPledge;
                RateAmount3 = (100 * Amount3) / AmountPledge;

                updAmount1.Value = (decimal)RateAmount1;
                updAmount2.Value = (decimal)RateAmount2;
                updAmount3.Value = (decimal)RateAmount3;
            }
            catch
            {
                MessageBox.Show("The amount you entered is not valid");
            }
        }

        private void txtAmountPledged_Leave(object sender, EventArgs e)
        {
            CalculatePledgeAmount();
        }

        private void updAmount1_ValueChanged(object sender, EventArgs e)
        {
            CalculatePledgeAmount();
        }

        private void updAmount2_ValueChanged(object sender, EventArgs e)
        {
            CalculatePledgeAmount();
        }

        private void updAmount3_ValueChanged(object sender, EventArgs e)
        {
            CalculatePledgeAmount();
        }

        private void txtAmount1_Leave(object sender, EventArgs e)
        {
            CalculatePledgeRate();
        }

        private void txtAmount2_Leave(object sender, EventArgs e)
        {
            CalculatePledgeRate();
        }

        private void txtAmount3_TextChanged(object sender, EventArgs e)
        {
            CalculatePledgeRate();
        }
    }
}
