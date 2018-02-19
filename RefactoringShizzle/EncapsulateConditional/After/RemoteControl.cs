using System;

namespace RefactoringShizzle.Encapsulate_Conditional.After
{
    public class RemoteControl
    {
        public string Functions { get; set; }
        public string Name { get; set; }
        public int CreatedYear { get; set; }

        private bool hasExtraFunctions { get { return (Functions.Length > 1 && Name == "RCA" && CreatedYear > DateTime.Now.Year - 2); } }

        public string PerformCoolFunction()
        {
            if (hasExtraFunctions)
                return "somethingelse";
            else return "somethingelse";
        }
    }
}