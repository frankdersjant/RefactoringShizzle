namespace RefactoringShizzle.ExtractInterface.Before
{
    public class RegistrationProcessor
    {
        public decimal ProcessRegistration(ClassRegistration classRegistration)
        {
            classRegistration.Create();
            return classRegistration.Total;
        }
    }
}
