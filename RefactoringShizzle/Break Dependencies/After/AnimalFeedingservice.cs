namespace RefactoringShizzle.Break_Dependencies.After
{
    public class AnimalFeedingservice
    {
        private IFeederService _Feederservice { get; set; }

        public AnimalFeedingservice(IFeederService Feederservice)
        {
            _Feederservice = Feederservice;
        }
        private bool FoodBowlEmpty { get; set; }

        private void Feed()
        {
            if (FoodBowlEmpty)
            {
                _Feederservice.ReplenishFood();
            }
        }
    }
}
