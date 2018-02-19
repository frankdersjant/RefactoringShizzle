namespace RefactoringShizzle.Break_Dependencies.After
{
    public class FeederService : IFeederService
    {
        public void ReplenishFood()
        {
            Feeder.ReplenishFood();
        }
    }
}
