namespace Algebra1
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabFactorial = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.btnCalcFactorial = new System.Windows.Forms.Button();
            this.tclAlgebra = new System.Windows.Forms.TabControl();
            this.tabFactorial.SuspendLayout();
            this.tclAlgebra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 175);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabFactorial
            // 
            this.tabFactorial.Controls.Add(this.btnCalcFactorial);
            this.tabFactorial.Controls.Add(this.txtFactorial);
            this.tabFactorial.Controls.Add(this.txtNumber);
            this.tabFactorial.Controls.Add(this.label2);
            this.tabFactorial.Controls.Add(this.label1);
            this.tabFactorial.Location = new System.Drawing.Point(4, 22);
            this.tabFactorial.Name = "tabFactorial";
            this.tabFactorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactorial.Size = new System.Drawing.Size(260, 135);
            this.tabFactorial.TabIndex = 0;
            this.tabFactorial.Text = "Factorial";
            this.tabFactorial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(88, 18);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(50, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number:";
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(88, 54);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(140, 20);
            this.txtFactorial.TabIndex = 3;
            this.txtFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcFactorial
            // 
            this.btnCalcFactorial.Location = new System.Drawing.Point(153, 18);
            this.btnCalcFactorial.Name = "btnCalcFactorial";
            this.btnCalcFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnCalcFactorial.TabIndex = 17;
            this.btnCalcFactorial.Text = "Calculate";
            this.btnCalcFactorial.UseVisualStyleBackColor = true;
            this.btnCalcFactorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // tclAlgebra
            // 
            this.tclAlgebra.Controls.Add(this.tabFactorial);
            this.tclAlgebra.HotTrack = true;
            this.tclAlgebra.Location = new System.Drawing.Point(12, 12);
            this.tclAlgebra.Name = "tclAlgebra";
            this.tclAlgebra.SelectedIndex = 0;
            this.tclAlgebra.Size = new System.Drawing.Size(268, 161);
            this.tclAlgebra.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 209);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tclAlgebra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial, Permutation, Combination";
            this.tabFactorial.ResumeLayout(false);
            this.tabFactorial.PerformLayout();
            this.tclAlgebra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabFactorial;
        private System.Windows.Forms.Button btnCalcFactorial;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tclAlgebra;
    }
}

