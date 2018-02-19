using System.Collections.Generic;

namespace RefactoringShizzle.ParameterObject.Before
{
    public class Registration
    {
        public void Create(decimal amount, Student student, IEnumerable<Course> courses, decimal credits)
        {
            //
        }
    }
}
