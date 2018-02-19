using System.Collections.Generic;

namespace RefactoringShizzle.RemoveDoubleNegative.After
{
    public class Order
    {
        public void Checkout(IEnumerable<Product> product, Customer customer)
        {
            if (!customer.IsFlagged)
            {
                return;
            }
        }
    }
}
