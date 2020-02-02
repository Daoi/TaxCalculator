namespace TaxCalculator
{
    partial class frmTaxCalc
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.lblTaxOwed = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(112, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(234, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Enabled = false;
            this.txtTaxableIncome.Location = new System.Drawing.Point(174, 64);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 20);
            this.txtTaxableIncome.TabIndex = 2;
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Enabled = false;
            this.txtTaxOwed.Location = new System.Drawing.Point(174, 100);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.ReadOnly = true;
            this.txtTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.txtTaxOwed.TabIndex = 3;
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Enabled = false;
            this.lblTaxableIncome.Location = new System.Drawing.Point(77, 64);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(86, 13);
            this.lblTaxableIncome.TabIndex = 4;
            this.lblTaxableIncome.Text = "Taxable Income:";
            // 
            // lblTaxOwed
            // 
            this.lblTaxOwed.AutoSize = true;
            this.lblTaxOwed.Enabled = false;
            this.lblTaxOwed.Location = new System.Drawing.Point(77, 103);
            this.lblTaxOwed.Name = "lblTaxOwed";
            this.lblTaxOwed.Size = new System.Drawing.Size(91, 13);
            this.lblTaxOwed.TabIndex = 5;
            this.lblTaxOwed.Text = "Income tax owed:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(279, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Enter Name:";
            // 
            // frmTaxCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(413, 205);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTaxOwed);
            this.Controls.Add(this.lblTaxableIncome);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmTaxCalc";
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.Label lblTaxOwed;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblName;
    }
}

