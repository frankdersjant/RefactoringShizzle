using System;

namespace RefactoringShizzle.Encapsulate_Conditional.Before
{
    public class RemoteControl
    {
        public string Functions { get; set; }
        public string Name { get; set; }
        public int CreatedYear { get; set; }

        public string PerformCoolFunction()
        {
            if (Functions.Length > 1 && Name == "RCA" && CreatedYear > DateTime.Now.Year - 2)
            {
                return "dosomething";
            }
            else
            {
                return "somethingelse";
            }
        }
    }
}
