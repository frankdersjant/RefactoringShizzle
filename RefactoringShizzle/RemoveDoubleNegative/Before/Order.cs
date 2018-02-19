using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringShizzle.RemoveDoubleNegative.Before
{
    public class Order
    {
        public void Checkout (IEnumerable<Product> product, Customer customer)
        {
            if(!customer.IsNotFlagged)
            {
                return;
            }
        }

    }
}
