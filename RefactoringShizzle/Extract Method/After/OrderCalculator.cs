using System.Collections.Generic;

namespace RefactoringShizzle.Extract_Method.After
{
    public class OrderCalculator
    {
        private decimal SubTotal { get; set; }
        private IList<OrderLineItem> OrderLineItems { get; set; }
        private IList<decimal> Discounts { get; set; }
        private decimal Tax { get; set; }

        public OrderCalculator(Order order)
        {
            OrderLineItems = order.OrderLineItems;
            Discounts = order.Discounts;
            Tax = order.Tax;
        }

        public decimal Calculate()
        {
            CalculateSubTotal();

            SubtractDiscounts();
            CalculateTax();

            return SubTotal;
        }

        private void CalculateSubTotal()
        {
            foreach (OrderLineItem orderline in OrderLineItems)
            {
                SubTotal += orderline.Price;
            }
        }

        private void SubtractDiscounts()
        {
            foreach (decimal discount in Discounts)
            {
                SubTotal -= discount;
            }
        }

        private void CalculateTax()
        {
            SubTotal = SubTotal + Tax;
        }


    }
}
