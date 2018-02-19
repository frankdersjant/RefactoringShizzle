using System.Collections.Generic;

namespace RefactoringShizzle.Lists.Before
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Province { get; set; }
        public IList<Order> Orders { get; set; }

        public string GetFullName()
        {
            return LastName + " " + FirstName;
        }
    }
}
