namespace RefactoringShizzle.FactoryClass.After
{
    public interface IPoliceCarFactory
    {
        PoliceCar Create(int mileage, bool requiresService);
    }
}
