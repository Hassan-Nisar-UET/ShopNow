using System.Collections.Generic;
using ShopNow.Roles.Dto;

namespace ShopNow.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}