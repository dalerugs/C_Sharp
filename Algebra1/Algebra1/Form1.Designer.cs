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
            this.tclAlgebra = new System.Windows.Forms.TabControl();
            this.tabFactorial = new System.Windows.Forms.TabPage();
            this.tabPermutation = new System.Windows.Forms.TabPage();
            this.tabCombination = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.txtPermutationR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPermutationN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPermutation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCombination = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCombinationR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalcPermutation = new System.Windows.Forms.Button();
            this.btnCalcCombination = new System.Windows.Forms.Button();
            this.btnCalcFactorial = new System.Windows.Forms.Button();
            this.txtCombinationN = new System.Windows.Forms.TextBox();
            this.tclAlgebra.SuspendLayout();
            this.tabFactorial.SuspendLayout();
            this.tabPermutation.SuspendLayout();
            this.tabCombination.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclAlgebra
            // 
            this.tclAlgebra.Controls.Add(this.tabFactorial);
            this.tclAlgebra.Controls.Add(this.tabPermutation);
            this.tclAlgebra.Controls.Add(this.tabCombination);
            this.tclAlgebra.HotTrack = true;
            this.tclAlgebra.Location = new System.Drawing.Point(12, 12);
            this.tclAlgebra.Name = "tclAlgebra";
            this.tclAlgebra.SelectedIndex = 0;
            this.tclAlgebra.Size = new System.Drawing.Size(268, 161);
            this.tclAlgebra.TabIndex = 0;
            // 
            // tabFactorial
            // 
            this.tabFactorial.Controls.Add(this.btnCalcFactorial);
            this.tabFactorial.Controls.Add(this.txtFactorial);
            this.tabFactorial.Controls.Add(this.label2);
            this.tabFactorial.Controls.Add(this.txtNumber);
            this.tabFactorial.Controls.Add(this.label1);
            this.tabFactorial.Location = new System.Drawing.Point(4, 22);
            this.tabFactorial.Name = "tabFactorial";
            this.tabFactorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactorial.Size = new System.Drawing.Size(260, 135);
            this.tabFactorial.TabIndex = 0;
            this.tabFactorial.Text = "Factorial";
            this.tabFactorial.UseVisualStyleBackColor = true;
            // 
            // tabPermutation
            // 
            this.tabPermutation.Controls.Add(this.btnCalcPermutation);
            this.tabPermutation.Controls.Add(this.txtPermutation);
            this.tabPermutation.Controls.Add(this.label5);
            this.tabPermutation.Controls.Add(this.txtPermutationR);
            this.tabPermutation.Controls.Add(this.label3);
            this.tabPermutation.Controls.Add(this.txtPermutationN);
            this.tabPermutation.Controls.Add(this.label4);
            this.tabPermutation.Location = new System.Drawing.Point(4, 22);
            this.tabPermutation.Name = "tabPermutation";
            this.tabPermutation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermutation.Size = new System.Drawing.Size(260, 135);
            this.tabPermutation.TabIndex = 1;
            this.tabPermutation.Text = "Permutation";
            this.tabPermutation.UseVisualStyleBackColor = true;
            // 
            // tabCombination
            // 
            this.tabCombination.Controls.Add(this.txtCombinationN);
            this.tabCombination.Controls.Add(this.btnCalcCombination);
            this.tabCombination.Controls.Add(this.txtCombination);
            this.tabCombination.Controls.Add(this.label6);
            this.tabCombination.Controls.Add(this.txtCombinationR);
            this.tabCombination.Controls.Add(this.label7);
            this.tabCombination.Controls.Add(this.label8);
            this.tabCombination.Location = new System.Drawing.Point(4, 22);
            this.tabCombination.Name = "tabCombination";
            this.tabCombination.Padding = new System.Windows.Forms.Padding(3);
            this.tabCombination.Size = new System.Drawing.Size(260, 135);
            this.tabCombination.TabIndex = 2;
            this.tabCombination.Text = "Combination";
            this.tabCombination.UseVisualStyleBackColor = true;
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
            // txtPermutationR
            // 
            this.txtPermutationR.Location = new System.Drawing.Point(88, 54);
            this.txtPermutationR.Name = "txtPermutationR";
            this.txtPermutationR.Size = new System.Drawing.Size(50, 20);
            this.txtPermutationR.TabIndex = 7;
            this.txtPermutationR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "n:";
            // 
            // txtPermutationN
            // 
            this.txtPermutationN.Location = new System.Drawing.Point(88, 18);
            this.txtPermutationN.Name = "txtPermutationN";
            this.txtPermutationN.Size = new System.Drawing.Size(50, 20);
            this.txtPermutationN.TabIndex = 5;
            this.txtPermutationN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "r:";
            // 
            // txtPermutation
            // 
            this.txtPermutation.Location = new System.Drawing.Point(88, 90);
            this.txtPermutation.Name = "txtPermutation";
            this.txtPermutation.Size = new System.Drawing.Size(140, 20);
            this.txtPermutation.TabIndex = 9;
            this.txtPermutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "P(n,r)";
            // 
            // txtCombination
            // 
            this.txtCombination.Location = new System.Drawing.Point(88, 90);
            this.txtCombination.Name = "txtCombination";
            this.txtCombination.Size = new System.Drawing.Size(140, 20);
            this.txtCombination.TabIndex = 15;
            this.txtCombination.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "C(n, r):";
            // 
            // txtCombinationR
            // 
            this.txtCombinationR.Location = new System.Drawing.Point(88, 54);
            this.txtCombinationR.Name = "txtCombinationR";
            this.txtCombinationR.Size = new System.Drawing.Size(50, 20);
            this.txtCombinationR.TabIndex = 13;
            this.txtCombinationR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "n:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "r:";
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
            // btnCalcPermutation
            // 
            this.btnCalcPermutation.Location = new System.Drawing.Point(153, 54);
            this.btnCalcPermutation.Name = "btnCalcPermutation";
            this.btnCalcPermutation.Size = new System.Drawing.Size(75, 23);
            this.btnCalcPermutation.TabIndex = 10;
            this.btnCalcPermutation.Text = "Calculate";
            this.btnCalcPermutation.UseVisualStyleBackColor = true;
            this.btnCalcPermutation.Click += new System.EventHandler(this.btnCalcPermutation_Click);
            // 
            // btnCalcCombination
            // 
            this.btnCalcCombination.Location = new System.Drawing.Point(153, 54);
            this.btnCalcCombination.Name = "btnCalcCombination";
            this.btnCalcCombination.Size = new System.Drawing.Size(75, 23);
            this.btnCalcCombination.TabIndex = 16;
            this.btnCalcCombination.Text = "Calculate";
            this.btnCalcCombination.UseVisualStyleBackColor = true;
            this.btnCalcCombination.Click += new System.EventHandler(this.btnCalcCombination_Click);
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
            // txtCombinationN
            // 
            this.txtCombinationN.Location = new System.Drawing.Point(88, 21);
            this.txtCombinationN.Name = "txtCombinationN";
            this.txtCombinationN.Size = new System.Drawing.Size(50, 20);
            this.txtCombinationN.TabIndex = 17;
            this.txtCombinationN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.tclAlgebra.ResumeLayout(false);
            this.tabFactorial.ResumeLayout(false);
            this.tabFactorial.PerformLayout();
            this.tabPermutation.ResumeLayout(false);
            this.tabPermutation.PerformLayout();
            this.tabCombination.ResumeLayout(false);
            this.tabCombination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclAlgebra;
        private System.Windows.Forms.TabPage tabFactorial;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPermutation;
        private System.Windows.Forms.TextBox txtPermutation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPermutationR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPermutationN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabCombination;
        private System.Windows.Forms.TextBox txtCombination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCombinationR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcFactorial;
        private System.Windows.Forms.Button btnCalcPermutation;
        private System.Windows.Forms.Button btnCalcCombination;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCombinationN;
    }
}

