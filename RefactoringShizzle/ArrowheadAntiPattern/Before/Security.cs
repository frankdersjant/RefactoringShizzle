using System.Collections.Generic;
using System.Linq;

namespace RefactoringShizzle.ArrowheadAntiPattern.Before
{
    public class Security
    {
        private ISecurityChecker _securityChecker { get; set; }

        public Security(ISecurityChecker securityChecker)
        {
            _securityChecker = securityChecker;
        }

        public bool HasAccess(User user, Permission permission , IEnumerable<Permission> exemption)
        {
            bool Haspermission = false;

            if (user != null)
            {
                if (permission != null)
                {
                    if (exemption.Count()==0)
                    {
                        if (_securityChecker.CheckPermissions(user, permission) || exemption.Contains(permission))

                            Haspermission = true;
                    }
                }
            }

            return Haspermission;
        }

    }
}
