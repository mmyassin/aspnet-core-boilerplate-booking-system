using System.Collections.Generic;
using BookingSystem.Roles.Dto;

namespace BookingSystem.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}