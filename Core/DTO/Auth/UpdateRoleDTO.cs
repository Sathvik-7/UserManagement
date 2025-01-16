using System.ComponentModel.DataAnnotations;

namespace UserManagement.BackEnd.Core.DTO.Auth
{
    public class UpdateRoleDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        public RoleType NewRole { get; set; }
    }

    public enum RoleType  
    {
        ADMIN,
        USER,
        MANAGER
    }
}
