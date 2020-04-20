using System.Collections.Generic;
using BookingSystem.Roles.Dto;

namespace BookingSystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
