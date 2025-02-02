using System.Collections.Generic;
using ShopNow.Roles.Dto;

namespace ShopNow.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
