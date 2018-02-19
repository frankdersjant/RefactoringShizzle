namespace RefactoringShizzle.Lists.After
{
    public class Order
    {
        public int Id { get; set; }
        private Customer _Customer { get; set; }

        public Order(Customer customer)
        {
            _Customer = customer;
        }
    }
}
