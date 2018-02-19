namespace RefactoringShizzle.ExtractSubClass.After
{
    public class NonRegistration : Registration
    {
        public NonRegistrationAction Action { get; set; }
        public string Notes { get; set; }
    }
}