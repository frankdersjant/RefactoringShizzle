namespace RefactoringShizzle.ExtractInterface.After
{
    public class RegistrationProcessor
    {
        public decimal ProcessRegistration(IClassRegistration classRegistration)
        {
            classRegistration.Create();
            return classRegistration.Total;
        }
    }
}
