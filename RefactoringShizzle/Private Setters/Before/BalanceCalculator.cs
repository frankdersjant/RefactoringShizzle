using System.Collections.Generic;
using System.Linq;

namespace RefactoringShizzle.Private_Setters.Before
{
    public class BalanceCalculator : IBalanceCalculator
    {
        private readonly Fee fee;

        public BalanceCalculator()
        {
            fee = new Fee();

        }

        public decimal Calculate()
        {
            IEnumerable<Payment> payments = fee.GetPayments();
            var totalAmount = payments.Sum(p => p.Amount);
            return fee.Amount - totalAmount;   
        }
    }
}
