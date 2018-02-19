namespace RefactoringShizzle.ReplaceInheritance.After
{
    public class Child
    {
        private Sanitation _sanitation { get; set; }

        public Child(Sanitation sant)
        {
            _sanitation = sant;
        }

        public Child()
        {
            _sanitation = new Sanitation();
        }

        public string Washing()
        {
            return _sanitation.WashHands();
        }
    }
}
