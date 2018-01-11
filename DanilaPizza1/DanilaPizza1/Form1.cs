using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanilaPizza1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculatePrice()
        {
            double PriceSize = 0, PriceEachTopping = 0, BWings = 0, Bread = 0, SodaCan = 0, Soda20 = 0, Soda2L = 0, OJ = 0, Water = 0, 
                PriceToppings = 0, TotalOrder = 0;
            int Pepperoni = 0, Sausage = 0, ExtraCheese = 0, Onions = 0, Olives = 0;
            bool error = false;
            try
            {
                if (rdoSmall.Checked)
                {
                    PriceSize = double.Parse(txtSmall.Text);
                }
                if (rdoMedium.Checked)
                {
                    PriceSize = double.Parse(txtMedium.Text);
                }
                if (rdoLarge.Checked)
                {
                    PriceSize = double.Parse(txtLarge.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The price you typed in the pizza size is not valid. Please try again");
                error = true;
            }
            if (chkPepperoni.Checked)
            {
                Pepperoni = 1;
            }
            if (chkSausage.Checked)
            {
                Sausage = 1;
            }
            if (chkExtraCheese.Checked)
            {
                ExtraCheese = 1;
            }
            if (chkOlives.Checked)
            {
                Olives = 1;
            }
            if (chkOnions.Checked)
            {
                Onions = 1;
            }
            try
            {
                PriceEachTopping = double.Parse(txtEachToppings.Text);
                PriceToppings = (Pepperoni+Sausage+ExtraCheese+Onions+Olives)*PriceEachTopping;
            }
            catch
            {
                MessageBox.Show("The price you typed in pizza toppings is not valid. Please try again.");
                error = true;
            }
            if (!error)
            {
                BWings = double.Parse(txtTotalWings.Text);
                Bread = double.Parse(txtTotalBread.Text);
                SodaCan = double.Parse(txtTotalCan.Text);
                Soda20 = double.Parse(txtTotalSoda20.Text);
                Soda2L = double.Parse(txtTotalSoda2L.Text);
                OJ = double.Parse(txtTotalOJ.Text);
                Water = double.Parse(txtTotalWater.Text);
                TotalOrder = PriceSize + PriceToppings + BWings + Bread + SodaCan + Soda20 + Soda2L + OJ + Water;
                txtTotalPrice.Text = TotalOrder.ToString("F");
            }
        }

        private void CalculateSideOrders()
        {
            int Qty = 0;
            double Price = 0;
            double Total = 0;
            try
            {
                Qty = int.Parse(txtQtyBread.Text);
                Price = double.Parse(txtPriceBread.Text);
                Total = Qty * Price;
                txtTotalBread.Text = Total.ToString("F");

                Qty = int.Parse(txtQtyWings.Text);
                Price = double.Parse(txtPriceWings.Text);
                Total = Qty * Price;
                txtTotalWings.Text = Total.ToString("F");

                CalculatePrice();
            }
            catch
            {
                MessageBox.Show("The price or quantity you typed in side orders is not valid. Please try again.");
            }
        }

        private void CalculateDrinks()
        {
            int Qty = 0;
            double Price = 0;
            double Total = 0;
            try
            {
                Qty = int.Parse(txtQtyCan.Text);
                Price = double.Parse(txtPriceCan.Text);
                Total = Qty * Price;
                txtTotalCan.Text = Total.ToString("F");

                Qty = int.Parse(txtQtySoda20.Text);
                Price = double.Parse(txtPriceSoda20.Text);
                Total = Qty * Price;
                txtTotalSoda20.Text = Total.ToString("F");

                Qty = int.Parse(txtQtySoda2L.Text);
                Price = double.Parse(txtPriceSoda2L.Text);
                Total = Qty * Price;
                txtTotalSoda2L.Text = Total.ToString("F");

                Qty = int.Parse(txtQtyOJ.Text);
                Price = double.Parse(txtPriceOJ.Text);
                Total = Qty * Price;
                txtTotalOJ.Text = Total.ToString("F");

                Qty = int.Parse(txtQtyWater.Text);
                Price = double.Parse(txtPriceWater.Text);
                Total = Qty * Price;
                txtTotalWater.Text = Total.ToString("F");

                CalculatePrice();

            }
            catch
            {
                MessageBox.Show("The price or quantity you typed in drinks is not valid. Please try again.");
                CalculatePrice();
            }
        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtQtyBread_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtQtyBread_Leave(object sender, EventArgs e)
        {
            CalculateSideOrders();
        }

        private void txtPriceBread_Leave(object sender, EventArgs e)
        {
            CalculateSideOrders();
        }

        private void txtQtyWings_Leave(object sender, EventArgs e)
        {
            CalculateSideOrders();
        }

        private void txtPriceWings_TextChanged(object sender, EventArgs e)
        {
            CalculateSideOrders();
        }

        private void txtQtyCan_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtPriceCan_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtQtySoda20_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtPriceSoda20_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtQtySoda2L_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtPriceSoda2L_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtQtyOJ_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtPriceOJ_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtQtyWater_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtPriceWater_Leave(object sender, EventArgs e)
        {
            CalculateDrinks();
        }

        private void txtSmall_Leave(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtMedium_Leave(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtLarge_Leave(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtEachToppings_Leave(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    }
}
