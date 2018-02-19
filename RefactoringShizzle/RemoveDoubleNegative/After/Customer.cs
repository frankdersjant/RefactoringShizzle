namespace RefactoringShizzle.RemoveDoubleNegative.After
{
    public class Customer
    {
        public decimal Balance {get; private set; }
        public bool IsFlagged { get { return Balance > 30m; } }
    }
}