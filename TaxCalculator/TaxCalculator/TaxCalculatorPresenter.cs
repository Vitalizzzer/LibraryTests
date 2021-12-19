using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public class TaxCalculatorPresenter
    {
        private ICalculatorView view;

        public TaxCalculatorPresenter(ICalculatorView view)
        {
            this.view = view;            
        }


        public void VerifyInput()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Заповніть, будь ласка, поле 'Прибуток'");
            }
        }


        private bool IsEmpty()
        {
            if (view.TxtIncome.Contains(" ") || view.TxtIncome.Length == 0)
                return true;
            return false;
        }

    }
}
