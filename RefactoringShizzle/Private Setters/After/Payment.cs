namespace RefactoringShizzle.Private_Setters.After
{
    public class Payment
    {
        public Payment(decimal amount, Fee fee)
        {
            Amount = amount;
            Fee = fee;
        }

        public decimal Amount { get; private set; }
        public Fee Fee { get; private set; }
    }
}
