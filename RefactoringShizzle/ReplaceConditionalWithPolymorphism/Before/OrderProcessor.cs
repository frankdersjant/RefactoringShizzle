using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringShizzle.ReplaceConditionalWithPolymorphism.Before
{
    public class OrderProcessor
    {
        public decimal ProcessOrder(Customer customer, IEnumerable<Product> products)
        {
            decimal orderTotal = products.Sum(p => p.Price);

            Type customerType = customer.GetType();

            if (customerType == typeof(Employee))
            {
                orderTotal -= orderTotal * 0.15m;
            }
            else if (customerType == typeof(NonEmployee))
            {
                orderTotal -= orderTotal * 0.05m;
            }
            return orderTotal;
        }
    }
}
