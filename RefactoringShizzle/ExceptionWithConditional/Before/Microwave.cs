namespace RefactoringShizzle.ExceptionWithConditional.Before
{
    public class Microwave
    {
        private IMicrowaveMotor Motor { get; set; }

        public bool Start(object food)
        {
            bool foodCooked = true;

            try
            {
                Motor.Cook(food);
                foodCooked = true;
            }
            catch (InUseException)
            {
                foodCooked = false;
            }

            return foodCooked;
        }
    }
}
