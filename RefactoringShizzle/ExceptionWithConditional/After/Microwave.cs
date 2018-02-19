namespace RefactoringShizzle.ExceptionWithConditional.After
{
    public class Microwave
    {
        private IMicrowaveMotor Motor { get; set; }
        private object food;

        public bool Start()
        {
            if (Motor.IsInUse())
                return false;

            Motor.Cook(food);

            return true;
        }
    }
}
