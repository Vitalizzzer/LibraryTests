using System.Windows;

namespace TaxCounter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            VerifyInput();
            decimal taxResult = CountTax();
            decimal incomeAfterTaxes = CountIncomeAfterTaxes(taxResult);
            decimal.TryParse(ParseDot(txtOtherCommission.Text), out decimal otherCommission);
            decimal commission = CountTransferCommission(incomeAfterTaxes, otherCommission);

            lblCommissionDisplay.Content = commission;
            lblTotalCommissionsDisplay.Content = commission + otherCommission;
            lblTotalTaxDisplay.Content = taxResult;
            lblCleanIncomeDisplay.Content = incomeAfterTaxes - commission - otherCommission;
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
            double.TryParse(ParseDot(txtCommissionPersent.Text), out double percent);

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
