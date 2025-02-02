using Abp.Authorization;
using ShopNow.Authorization.Roles;
using ShopNow.Authorization.Users;

namespace ShopNow.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
