using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventory1
{
    public partial class CarInventory : Form
    {
        private int reviewPosition;
        private Car[] Cars = new Car[15];

        private String[] pictures0;
        private String[] pictures1 = new String[5];
        private String[] pictures2 = new String[3];
        private String[] pictures3 = new String[0];
        private String[] pictures4 = new String[3];
        private String[] pictures5 = new String[3];
        private String[] pictures6 = new String[3];
        private String[] pictures7 = new String[0];
        private String[] pictures8 = new String[0];
        private String[] pictures9 = new String[0];
        private String[] pictures10 = new String[3];
        private String[] pictures11 = new String[4];
        private String[] pictures12 = new String[0];
        private String[] pictures13 = new String[7];
        private String[] pictures14 = new String[2];


        public CarInventory()
        {
            InitializeComponent();
            InitailizeCars();
        }

        private void InitailizeCars()
        {
            Cars[0] = new Car();
            Cars[0].Make = "BMW";
            Cars[0].Model = "335i";
            Cars[0].Year = 2007;
            Cars[0].Price = 42580;
            Cars[0].Picture = "335iA.gif";

            Cars[1] = new Car();
            Cars[1].Make = "Honda";
            Cars[1].Model = "Accord";
            Cars[1].Year = 2007;
            Cars[1].Price = 24550;
            Cars[1].Picture = "Accord1.gif";

            Cars[2] = new Car();
            Cars[2].Make = "Chevrolet";
            Cars[2].Model = "Avalanche";
            Cars[2].Year = 2007;
            Cars[2].Price = 36880;
            Cars[2].Picture = "Avalanche1.gif";

            Cars[3] = new Car();
            Cars[3].Make = "Volvo";
            Cars[3].Model = "C70";
            Cars[3].Year = 1997;
            Cars[3].Price = 42320;
            Cars[3].Picture = "C70.gif";

            Cars[4] = new Car();
            Cars[4].Make = "Land Rover";
            Cars[4].Model = "LR3";
            Cars[4].Year = 2007;
            Cars[4].Price = 46245;
            Cars[4].Picture = "LR3a.gif";

            Cars[5] = new Car();
            Cars[5].Make = "Honda";
            Cars[5].Model = "Civic";
            Cars[5].Year = 2000;
            Cars[5].Price = 22665;
            Cars[5].Picture = "Civic1.gif";

            Cars[6] = new Car();
            Cars[6].Make = "Mazda";
            Cars[6].Model = "Mazda5";
            Cars[6].Year = 2007;
            Cars[6].Price = 20845;
            Cars[6].Picture = "Mazda5a.gif";

            Cars[7] = new Car();
            Cars[7].Make = "Ford";
            Cars[7].Model = "Escape";
            Cars[7].Year = 1997;
            Cars[7].Price = 22445;
            Cars[7].Picture = "Escape.gif";

            Cars[8] = new Car();
            Cars[8].Make = "Acura";
            Cars[8].Model = "TSX";
            Cars[8].Year = 2006;
            Cars[8].Price = 26445;
            Cars[8].Picture = "TSX.gif";

            Cars[9] = new Car();
            Cars[9].Make = "Mazda";
            Cars[9].Model = "Miata";
            Cars[9].Year = 2008;
            Cars[9].Price = 24180;
            Cars[9].Picture = "Miata.gif";

            Cars[10] = new Car();
            Cars[10].Make = "Ford";
            Cars[10].Model = "F-150";
            Cars[10].Year = 2006;
            Cars[10].Price = 20475;
            Cars[10].Picture = "F150a.gif";

            Cars[11] = new Car();
            Cars[11].Make = "Volvo";
            Cars[11].Model = "S40";
            Cars[11].Year = 2008;
            Cars[11].Price = 25285;
            Cars[11].Picture = "S40a.gif";

            Cars[12] = new Car();
            Cars[12].Make = "BMW";
            Cars[12].Model = "750i";
            Cars[12].Year = 2007;
            Cars[12].Price = 88925;
            Cars[12].Picture = "750Li.gif";

            Cars[13] = new Car();
            Cars[13].Make = "Buick";
            Cars[13].Model = "LaCrosse";
            Cars[13].Year = 2002;
            Cars[13].Price = 28685;
            Cars[13].Picture = "LaCrosse1.gif";

            Cars[14] = new Car();
            Cars[14].Make = "Ford";
            Cars[14].Model = "E-150 XL";
            Cars[14].Year = 2002;
            Cars[14].Price = 26660;
            Cars[14].Picture = "E150XLa.gif";

            pictures0 = new string[9]
            {
                "335iA.gif", "335iB.gif", "335iC.gif",
                "335iD.gif", "335iE.gif", "335iF.gif",
                "335iG.gif", "335iH.gif", "335iI.gif"
            };
            pictures1 = new string[]
            {
                "Accord1.gif", "Accord2.gif", "Accord3.gif",
                "Accord4.gif", "Accord5.gif", "Accord6.gif"
            };
            pictures2 = new string[]
            {
                "Avalanche1.gif", "Avalanche2.gif",
                "Avalanche3.gif", "Avalanche4.gif"
            };
            pictures4 = new string[]
            {
                "LR3a.gif", "LR3b.gif",
                "LR3b.gif", "LR3d.gif"
            };
            pictures5 = new string[]
            {
                "Civic1.gif", "Civic2.gif",
                "Civic3.gif", "Civic4.gif"
            };
            pictures6 = new string[]
            {
                "Mazda5a.gif", "Mazda5b.gif",
                "Mazda5c.gif", "Mazda5d.gif"
            };
            pictures10 = new string[]
            {
                "F150a.gif", "F150b.gif",
                "F150c.gif", "F150d.gif"
            };
            pictures11 = new string[]
            {
                "S40a.gif", "S40b.gif",
                "S40c.gif", "S40d.gif", "S40e.gif"
            };
            pictures13 = new string[]
            {
                "LaCrosse1.gif", "LaCrosse2.gif", "LaCrosse3.gif",
                "LaCrosse4.gif", "LaCrosse5.gif", "LaCrosse6.gif",
                "LaCrosse7.gif", "LaCrosse8.gif"
            };
            pictures14 = new string[]
            {
                "E150XLa.gif", "E150XLb.gif"
            };
        }

        private void tbrReview_Scroll(object sender, EventArgs e)
        {
            reviewPosition = tbrReview.Value;
            txtMake.Text = Cars[reviewPosition].Make;
            txtModel.Text = Cars[reviewPosition].Model;
            txtYear.Text = Cars[reviewPosition].Year.ToString();
            txtPrice.Text = Cars[reviewPosition].Price.ToString();
            pbxCarImage.Image = Image.FromFile(Cars[reviewPosition].Picture);
            switch (reviewPosition)
            {
                case 0:
                    tbrImages.Maximum = 8;
                    break;
                case 1:
                    tbrImages.Maximum = 5;
                    break;
                case 2:
                    tbrImages.Maximum = 3;
                    break;
                case 3:
                    tbrImages.Maximum = 0;
                    break;
                case 4:
                    tbrImages.Maximum = 3;
                    break;
                case 5:
                    tbrImages.Maximum = 3;
                    break;
                case 6:
                    tbrImages.Maximum = 3;
                    break;
                case 7:
                    tbrImages.Maximum = 0;
                    break;
                case 8:
                    tbrImages.Maximum = 0;
                    break;
                case 9:
                    tbrImages.Maximum = 0;
                    break;
                case 10:
                    tbrImages.Maximum = 3;
                    break;
                case 11:
                    tbrImages.Maximum = 4;
                    break;
                case 12:
                    tbrImages.Maximum = 0;
                    break;
                case 13:
                    tbrImages.Maximum = 7;
                    break;
                case 14:
                    tbrImages.Maximum = 1;
                    break;
            }
            tbrImages.Value = 0;

        }

        private void tbrImages_Scroll(object sender, EventArgs e)
        {
            switch (reviewPosition)
            {
                case 0:
                    pbxCarImage.Image = Image.FromFile(pictures0[tbrImages.Value]);
                    break;
                case 1:
                    pbxCarImage.Image = Image.FromFile(pictures1[tbrImages.Value]);
                    break;
                case 2:
                    pbxCarImage.Image = Image.FromFile(pictures2[tbrImages.Value]);
                    break;
                case 3:
                    pbxCarImage.Image = Image.FromFile(pictures3[tbrImages.Value]);
                    break;
                case 4:
                    pbxCarImage.Image = Image.FromFile(pictures4[tbrImages.Value]);
                    break;
                case 5:
                    pbxCarImage.Image = Image.FromFile(pictures5[tbrImages.Value]);
                    break;
                case 6:
                    pbxCarImage.Image = Image.FromFile(pictures6[tbrImages.Value]);
                    break;
                case 7:
                    pbxCarImage.Image = Image.FromFile(pictures7[tbrImages.Value]);
                    break;
                case 8:
                    pbxCarImage.Image = Image.FromFile(pictures8[tbrImages.Value]);
                    break;
                case 9:
                    pbxCarImage.Image = Image.FromFile(pictures9[tbrImages.Value]);
                    break;
                case 10:
                    pbxCarImage.Image = Image.FromFile(pictures10[tbrImages.Value]);
                    break;
                case 11:
                    pbxCarImage.Image = Image.FromFile(pictures11[tbrImages.Value]);
                    break;
                case 12:
                    pbxCarImage.Image = Image.FromFile(pictures12[tbrImages.Value]);
                    break;
                case 13:
                    pbxCarImage.Image = Image.FromFile(pictures13[tbrImages.Value]);
                    break;
                case 14:
                    pbxCarImage.Image = Image.FromFile(pictures14[tbrImages.Value]);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
