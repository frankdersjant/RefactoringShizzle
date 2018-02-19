namespace RefactoringShizzle.RemoveDoubleNegative.Before
{
    public class Customer
    {
        public decimal Balance { get; set; }
        public bool IsNotFlagged { get { return Balance < 30m; }}
    }
}