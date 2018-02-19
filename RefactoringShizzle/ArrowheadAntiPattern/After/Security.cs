using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringShizzle.ArrowheadAntiPattern.After
{
    public class Security
    {
        private ISecurityChecker _securityChecker { get; set; }

        public Security(ISecurityChecker securityChecker)
        {
            _securityChecker = securityChecker;
        }

        public bool HasAccess(User user, Permission permission, IEnumerable<Permission> exemption)
        {
            if (user == null || permission == null) return false;
            if (exemption.Contains(permission)) return true;

            return _securityChecker.CheckPermissions(user, permission);
        }
    }
}
