using System;

namespace RefactoringShizzle.ExtractSubClass.Before
{
    public class Registration
    {
        public NonRegistrationAction Action { get; set; }
        public decimal RegistrationTotal { get; set; }
        public string Notes { get; set; }
        public string Description { get; set; }
        public DateTime Registrationdate { get; set; }
    }
}
