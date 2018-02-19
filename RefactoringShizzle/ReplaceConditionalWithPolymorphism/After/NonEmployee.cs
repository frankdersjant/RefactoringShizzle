namespace RefactoringShizzle.ReplaceConditionalWithPolymorphism.After
{
    public class NonEmployee : Customer
    {
        public override decimal DiscountPercentage { get { return 0.05m; } }
    }
}
