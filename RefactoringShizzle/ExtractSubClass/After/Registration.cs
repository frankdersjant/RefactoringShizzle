using System;

namespace RefactoringShizzle.ExtractSubClass.After
{
    public class Registration
    {
        public decimal RegistrationTotal { get; set; }
        public string Description { get; set; }
        public DateTime Registrationdate
        {
            get; set;
        }
    }
}
