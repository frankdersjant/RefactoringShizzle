using RefactoringShizzle.GodClasses.Before;
using System.Collections.Generic;

namespace RefactoringShizzle.GodClasses.After
{
    public class CustomerOrderService
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

      
    }
}
