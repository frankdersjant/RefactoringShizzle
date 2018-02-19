using System.Collections.Generic;

namespace RefactoringShizzle.ParameterObject.After
{
    public class RegistrationContext
    {
        public decimal amount { get; set; }
        public Student student { get; set; } 
        public IEnumerable<Course> courses { get; set; } 
        public decimal credits { get; set; }
    }
}
