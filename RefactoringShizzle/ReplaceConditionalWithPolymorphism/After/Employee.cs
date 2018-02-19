namespace RefactoringShizzle.ReplaceConditionalWithPolymorphism.After
{
    public class Employee : Customer
    {
        public override decimal DiscountPercentage {get {return 0.15m;} }
    }
}
