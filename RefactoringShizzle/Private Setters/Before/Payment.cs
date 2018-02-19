namespace RefactoringShizzle.Private_Setters.Before
{
    public class Payment
    {
        public Payment(decimal amount, Fee fee)
        {
            Amount = amount;
            Fee = fee;
        }

        public decimal Amount { get; set; }
        public Fee Fee { get; set; }
    }
}
