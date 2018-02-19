using System.Collections.Generic;
using System.Linq;

namespace RefactoringShizzle.Return_ASAP.Before
{
    public class Order
    {
        public Customer Customer { get; private set; }

        public decimal CalaculateOrder(Customer customer, IEnumerable<Product> products, decimal discounts)
        {
            Customer = customer;
            decimal orderTotal = 0m;

            if (products.Count() > 0)
            {
                orderTotal = products.Sum(p => p.Price);
                if (discounts > 0)
                {
                    orderTotal -= discounts;
                }
            }
            return orderTotal;
        }
    }
}
