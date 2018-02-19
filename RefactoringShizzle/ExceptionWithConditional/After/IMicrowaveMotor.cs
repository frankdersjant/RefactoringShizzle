using System;

namespace RefactoringShizzle.ExceptionWithConditional.After
{
    public interface IMicrowaveMotor
    {
        void Cook(Object food);
        bool IsInUse();
    }
}
