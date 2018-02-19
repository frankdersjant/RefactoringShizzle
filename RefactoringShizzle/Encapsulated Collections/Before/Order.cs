namespace RefactoringShizzle.Lists.Before
{
    public class Order
    {
        public int Id { get; set; }
        private Customer _Customer { get; set; }

        public Order(Customer customer)
        {
            _Customer = customer;
            customer.Orders.Add(this);

        }
    }
}
