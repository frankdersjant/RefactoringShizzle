namespace RefactoringShizzle.ArrowheadAntiPattern.After
{
    public interface ISecurityChecker
    {
        bool CheckPermissions(User user, Permission permission);
    }
}
