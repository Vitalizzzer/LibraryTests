
namespace TaxCalculator
{
    public interface ICalculatorView
    {
        string TxtIncome {get;}
        void VerifyInput();
        decimal CountTax();
        decimal CountIncomeAfterTaxes(decimal tax);
        decimal CountTransferCommission(decimal incomeAfterTaxes, decimal otherCommisions);

    }
}
