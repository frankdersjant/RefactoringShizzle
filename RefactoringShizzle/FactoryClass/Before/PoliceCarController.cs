namespace RefactoringShizzle.FactoryClass.Before
{
    public class PoliceCarController
    {
        public PoliceCar New(int mileage, bool serviceRequired)
        {
            PoliceCar policeCar = new PoliceCar();
            policeCar.Mileage = mileage;
            policeCar.requiresService = serviceRequired;

            return policeCar;
        }
    }
}
