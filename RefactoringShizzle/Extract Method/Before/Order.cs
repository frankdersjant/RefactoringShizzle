using System.Collections.Generic;

namespace RefactoringShizzle.Extract_Method.Before
{
    public class Order
    {
        private IList<OrderLineItem> OrderLineItems { get; set; }
        private IList<decimal> Discounts { get; set; }
        private decimal Tax { get; set; }

        public void Calculate()
        {
            decimal subTotal = 0m;

            foreach (OrderLineItem orderline in OrderLineItems)
            {
                subTotal += orderline.Price; 
            }

            foreach (decimal discount in Discounts)
            {
                subTotal -= discount;
            }

            decimal tax = subTotal + Tax;

            decimal grandtotal = subTotal + tax;
        }
    }
}
