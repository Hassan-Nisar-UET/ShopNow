using System.Collections.Generic;
using ShopNow.Roles.Dto;

namespace ShopNow.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
