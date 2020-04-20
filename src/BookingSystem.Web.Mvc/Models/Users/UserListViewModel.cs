using System.Collections.Generic;
using BookingSystem.Roles.Dto;

namespace BookingSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
