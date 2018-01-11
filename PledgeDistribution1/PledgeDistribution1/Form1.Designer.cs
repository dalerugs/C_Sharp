namespace PledgeDistribution1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountPledged = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updAmount1 = new System.Windows.Forms.NumericUpDown();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.updAmount2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount3 = new System.Windows.Forms.TextBox();
            this.updAmount3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updAmount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAmount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAmount3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount Pledged:";
            // 
            // txtAmountPledged
            // 
            this.txtAmountPledged.Location = new System.Drawing.Point(131, 12);
            this.txtAmountPledged.Name = "txtAmountPledged";
            this.txtAmountPledged.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPledged.TabIndex = 1;
            this.txtAmountPledged.Text = "0.00";
            this.txtAmountPledged.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountPledged.Leave += new System.EventHandler(this.txtAmountPledged_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rotherham College";
            // 
            // updAmount1
            // 
            this.updAmount1.DecimalPlaces = 1;
            this.updAmount1.Location = new System.Drawing.Point(131, 49);
            this.updAmount1.Name = "updAmount1";
            this.updAmount1.Size = new System.Drawing.Size(57, 20);
            this.updAmount1.TabIndex = 3;
            this.updAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updAmount1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.updAmount1.ValueChanged += new System.EventHandler(this.updAmount1_ValueChanged);
            // 
            // txtAmount1
            // 
            this.txtAmount1.Location = new System.Drawing.Point(215, 48);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.Size = new System.Drawing.Size(84, 20);
            this.txtAmount1.TabIndex = 4;
            this.txtAmount1.Text = "0.00";
            this.txtAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount1.Leave += new System.EventHandler(this.txtAmount1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(215, 74);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(84, 20);
            this.txtAmount2.TabIndex = 8;
            this.txtAmount2.Text = "0.00";
            this.txtAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount2.Leave += new System.EventHandler(this.txtAmount2_Leave);
            // 
            // updAmount2
            // 
            this.updAmount2.DecimalPlaces = 1;
            this.updAmount2.Location = new System.Drawing.Point(131, 75);
            this.updAmount2.Name = "updAmount2";
            this.updAmount2.Size = new System.Drawing.Size(57, 20);
            this.updAmount2.TabIndex = 7;
            this.updAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updAmount2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.updAmount2.ValueChanged += new System.EventHandler(this.updAmount2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Leicester University";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // txtAmount3
            // 
            this.txtAmount3.Location = new System.Drawing.Point(215, 100);
            this.txtAmount3.Name = "txtAmount3";
            this.txtAmount3.Size = new System.Drawing.Size(84, 20);
            this.txtAmount3.TabIndex = 12;
            this.txtAmount3.Text = "0.00";
            this.txtAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount3.TextChanged += new System.EventHandler(this.txtAmount3_TextChanged);
            // 
            // updAmount3
            // 
            this.updAmount3.DecimalPlaces = 1;
            this.updAmount3.Location = new System.Drawing.Point(131, 101);
            this.updAmount3.Name = "updAmount3";
            this.updAmount3.Size = new System.Drawing.Size(57, 20);
            this.updAmount3.TabIndex = 11;
            this.updAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updAmount3.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.updAmount3.ValueChanged += new System.EventHandler(this.updAmount3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lars Union Academy";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(18, 141);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 172);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount3);
            this.Controls.Add(this.updAmount3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount2);
            this.Controls.Add(this.updAmount2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount1);
            this.Controls.Add(this.updAmount1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountPledged);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pledge Distribution";
            ((System.ComponentModel.ISupportInitialize)(this.updAmount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAmount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAmount3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountPledged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updAmount1;
        private System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.NumericUpDown updAmount2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount3;
        private System.Windows.Forms.NumericUpDown updAmount3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMessage;
    }
}

