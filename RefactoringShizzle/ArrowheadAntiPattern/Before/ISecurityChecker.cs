namespace RefactoringShizzle.ArrowheadAntiPattern.Before
{
    public interface ISecurityChecker
    {
        bool CheckPermissions(User user, Permission permission);
    }
}
