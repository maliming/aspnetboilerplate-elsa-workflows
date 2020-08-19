using Abp.Authorization;
using ElsaProject.Authorization.Roles;
using ElsaProject.Authorization.Users;

namespace ElsaProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
