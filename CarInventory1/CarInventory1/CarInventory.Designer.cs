namespace CarInventory1
{
    partial class CarInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCarImage = new System.Windows.Forms.PictureBox();
            this.tbrImages = new System.Windows.Forms.TrackBar();
            this.tbrReview = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrReview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Description";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(79, 132);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(79, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(79, 72);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(79, 42);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(150, 20);
            this.txtMake.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make:";
            // 
            // pbxCarImage
            // 
            this.pbxCarImage.Location = new System.Drawing.Point(266, 12);
            this.pbxCarImage.Name = "pbxCarImage";
            this.pbxCarImage.Size = new System.Drawing.Size(304, 196);
            this.pbxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCarImage.TabIndex = 1;
            this.pbxCarImage.TabStop = false;
            // 
            // tbrImages
            // 
            this.tbrImages.Location = new System.Drawing.Point(576, 12);
            this.tbrImages.Name = "tbrImages";
            this.tbrImages.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrImages.Size = new System.Drawing.Size(45, 196);
            this.tbrImages.TabIndex = 2;
            this.tbrImages.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbrImages.Scroll += new System.EventHandler(this.tbrImages_Scroll);
            // 
            // tbrReview
            // 
            this.tbrReview.Location = new System.Drawing.Point(12, 215);
            this.tbrReview.Name = "tbrReview";
            this.tbrReview.Size = new System.Drawing.Size(558, 45);
            this.tbrReview.TabIndex = 3;
            this.tbrReview.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbrReview.Scroll += new System.EventHandler(this.tbrReview_Scroll);
            // 
            // CarInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 266);
            this.Controls.Add(this.tbrReview);
            this.Controls.Add(this.tbrImages);
            this.Controls.Add(this.pbxCarImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarInventory";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCarImage;
        private System.Windows.Forms.TrackBar tbrImages;
        private System.Windows.Forms.TrackBar tbrReview;
    }
}

