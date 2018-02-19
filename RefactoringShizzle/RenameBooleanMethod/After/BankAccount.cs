namespace RefactoringShizzle.RenameBooleanMethod.After
{
    public class BankAccount
    {
        public void CreateAccountWithChecking(Customer customer)
        {
            CreateAccount(customer, true, false);
        }

        public void CreateAccountWithCheckingandSaving(Customer customer)
        {
            CreateAccount(customer, true, true);
        }

        public void CreateAccount(Customer customer, bool withChecking, bool withSaving)
        {

        }
    }
}
