using RefactoringShizzle.Lists.After;
using System.Collections.Generic;

namespace RefactoringShizzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //List test
            Customer customer = new Customer {Id = 1, FirstName = "frank", LastName = "Dersjant", Province= "Noord-Holland"};
            Order newOrder = new Order(customer);

            //customer.Orders.Add zis will not work....

            customer.AddOrder(newOrder);
            List<Order> ordersincustomer = (List<Order>) customer.Orders;
        }
    }
}
