namespace RefactoringShizzle.Break_Dependencies.Before
{
    public class AnimalFeedingService
    {
        private bool FoodBowlEmpty { get; set; }

        private void Feed()
        {
            if (FoodBowlEmpty)
            {
                Feeder.ReplenishFood();
            }
        }

    }
}
