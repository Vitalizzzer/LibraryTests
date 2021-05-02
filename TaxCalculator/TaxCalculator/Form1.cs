using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            VerifyInput();
            decimal taxResult = CountTax();
            decimal incomeAfterTaxes = CountIncomeAfterTaxes(taxResult);
            decimal.TryParse(ParseDot(txtOtherCommissions.Text), out decimal otherCommission);
            decimal commission = CountTransferCommission(incomeAfterTaxes, otherCommission);

            lblTransCommissionResult.Text = commission.ToString();
            lblAllCommissionsResult.Text = (commission + otherCommission).ToString();
            lblTotalTaxesResult.Text = taxResult.ToString();
            lblCleanIncomeResult.Text = (incomeAfterTaxes - commission - otherCommission).ToString();
        }

        private void VerifyInput()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Заповніть, будь ласка, поле 'Зарплата'");
            }
        }


        private bool IsEmpty()
        {
            if (txtIncome.Text.Contains(" ") || txtIncome.Text.Length == 0)
                return true;
            return false;
        }

        private decimal CountTax()
        {
            decimal.TryParse(ParseDot(txtIncome.Text), out decimal salary);
            decimal.TryParse(ParseDot(txtEsv.Text), out decimal esv);
            decimal.TryParse(ParseDot(txtEp.Text), out decimal ep);

            return salary * (ep / 100) + esv;
        }

        private decimal CountIncomeAfterTaxes(decimal tax)
        {
            decimal.TryParse(ParseDot(txtIncome.Text), out decimal salary);
            return salary - tax;
        }

        private decimal CountTransferCommission(decimal incomeAfterTaxes, decimal otherCommisions)
        {
            decimal readyForTransfer = incomeAfterTaxes - otherCommisions;
            double income = (double)readyForTransfer;
            double.TryParse(ParseDot(txtTransCommission.Text), out double percent);

            double percentNum = (percent / 100) + 1;
            decimal salaryWithoutCommission = (decimal)(income / percentNum);
            decimal transferCommission = readyForTransfer - salaryWithoutCommission;

            return transferCommission;
        }

        private string ParseDot(string input)
        {
            return input.Replace(".", ",");
        }

    }
}
