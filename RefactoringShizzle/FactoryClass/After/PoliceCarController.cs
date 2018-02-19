namespace RefactoringShizzle.FactoryClass.After
{
    public class PoliceCarController
    {
        private IPoliceCarFactory _policaCarFactory { get; set; }

        public PoliceCarController(IPoliceCarFactory policeCarFactory)
        {
            _policaCarFactory = policeCarFactory;
        }

        public PoliceCar New(int mileage, bool requiresService)
        {
            return _policaCarFactory.Create(mileage, requiresService);
        }
    }
}
