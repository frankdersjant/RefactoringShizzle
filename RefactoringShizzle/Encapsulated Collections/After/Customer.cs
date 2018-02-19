using System.Collections.Generic;

namespace RefactoringShizzle.Lists.After
{
    public class Customer
    {
        private readonly IList<Order> _orders;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Province { get; set; }
        public IEnumerable<Order> Orders { get { return _orders; } }

        public Customer()
        {
            _orders = new List<Order>();
        }

        public string GetFullName()
        {
            return LastName + " " + FirstName;
        }


        //could be public ...
        internal void AddOrder(Order order)
        {
            _orders.Add(order);
        }
    }
}
