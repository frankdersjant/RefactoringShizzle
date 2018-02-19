using System.Collections.Generic;

namespace RefactoringShizzle.GodClasses.Before
{
    public class CustomerService
    {
        public decimal CalculateOrderDiscount(IEnumerable<Product> products, Customer customer)
        {
            return 1m;
        }

        public bool CustomerIsValid(Customer customer, Order order)
        {
            return true;
        }

        public IEnumerable<string> GatherOrderErrors(IEnumerable<Product> products, Customer customer)
        {
            return null;
        }

        public void Register()
        {
        }

        public void ForgotPassword()
        {

        }
    }
}
