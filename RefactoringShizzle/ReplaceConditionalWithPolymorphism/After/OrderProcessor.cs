using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringShizzle.ReplaceConditionalWithPolymorphism.After
{
    public class OrderProcessor
    {
        public decimal ProcessOrder(Customer customer, IEnumerable<Product> products)
        {
            decimal orderTotal = products.Sum(p => p.Price);

            orderTotal -= orderTotal * customer.DiscountPercentage;
            return orderTotal;
        }
    }
}
