using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TaxCalculator
{
    //Look up tax bracket and calculate
    //Taxable income
    public partial class frmTaxCalc : Form
    {
        //Tax Table
        //The key for the table is a lambda function that compares the value put in
        //To the ranges for the tax brackets
        //It then returns a string which is split, to get the values for the flat amount,
        //The percent extra, and the "over excess" amount (i.e. the previous taxbracket's top end)
         Dictionary<Func<decimal, bool>, string> taxTable = new Dictionary<Func<decimal, bool>, string>()
            {
                {taxableIncome => taxableIncome >= 0.0m && taxableIncome <= 9225.0m, "0|.10|0"  },
                {taxableIncome => taxableIncome >= 9225.01m && taxableIncome <= 37450.0m, "922.50|.15|9225"  },
                {taxableIncome => taxableIncome >= 37450.01m && taxableIncome <= 90750.0m, "5156.25|.25|37450"  },
                {taxableIncome => taxableIncome >= 90750.01m && taxableIncome <= 189300.0m, "18481.25|.28|90750"  },
                {taxableIncome => taxableIncome >= 189300.01m && taxableIncome <= 411500.0m, "46075.25|.33|189300"  },
                {taxableIncome => taxableIncome >= 411500.01m && taxableIncome <= 413200.0m, "119401.25|.35|411500"  },
                {taxableIncome => taxableIncome >= 413200.01m, "119996.25|.396|413200"  },
            };



        public frmTaxCalc()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")) //Regex to check for valid name
            {
                MessageBox.Show("Please enter a valid name to continue(Alphabet only)", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else {
                lblTaxableIncome.Enabled = true;
                txtTaxableIncome.Enabled = true;
                lblTaxOwed.Enabled = true;
                txtTaxOwed.Enabled = true;
                btnCalculate.Enabled = true;
                txtTaxableIncome.Focus();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (validateIncome(txtTaxableIncome.Text)) { 
            txtTaxOwed.Text = (taxTableLookup(Convert.ToDecimal(txtTaxableIncome.Text))).ToString("c");
            }
            else
            {
                
            }
        }

        //Creates a lambda function to pass into the dictionry as a key
        //Passes the argument into the lambda function for the dictionary key
        //Gets the string value, parses for appropriate values for calculation
        //returns taxable income
        private decimal taxTableLookup(decimal taxableIncome)
        {
            var key = taxTable.Keys.Single(tI => tI(taxableIncome));
            string[] value = taxTable[key].Split('|');

            return Convert.ToDecimal(value[0]) + (Convert.ToDecimal(value[1]) * (taxableIncome - Convert.ToDecimal(value[2])));       

        }
        //Validates the income using try/catch/check for negative value
        private bool validateIncome(string value)
        {
            try
            {
                decimal income = Convert.ToDecimal(value);
                if(income <= 0)
                {
                    MessageBox.Show("Invalid invoice value, should be > 0", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaxableIncome.Text = "";
                    txtTaxableIncome.Focus();
                    return false;

                }
                return true;
            }
            catch
            {
                MessageBox.Show("Invalid income value, should be numeric only and greater than 0", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaxableIncome.Text = "";
                txtTaxableIncome.Focus();
                return false;
            }

        }
    }
}
