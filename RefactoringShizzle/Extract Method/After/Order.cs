using System.Collections.Generic;

namespace RefactoringShizzle.Extract_Method.After
{
    public class Order
    {
        public IList<OrderLineItem> OrderLineItems { get; set; }
        public IList<decimal> Discounts { get; set; }
        public decimal Tax { get; set; }

        public decimal Calculate()
        {
            return new OrderCalculator(this).Calculate();
        }
    }
}
