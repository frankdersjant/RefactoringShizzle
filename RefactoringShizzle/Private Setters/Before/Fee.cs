using System.Collections.Generic;

namespace RefactoringShizzle.Private_Setters.Before
{
    public class Fee
    {
        private readonly Customer _customer;
        private readonly IList<Payment> _payments;
        public decimal Amount { get; private set; }
        public decimal Balance { get; private set; }

        public Fee()
        {
            _payments = new List<Payment>();
        }

        public Fee(decimal amount, Customer customer)
        {
            Amount = amount;
            _customer = customer;
        }

       

        public IEnumerable<Payment> GetPayments()
        {
            return _payments;
        }
    }
}