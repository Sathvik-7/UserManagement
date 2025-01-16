using System.Security.Claims;
using UserManagement.BackEnd.Core.DTO.Auth;
using UserManagement.BackEnd.Core.DTO.General;

namespace UserManagement.BackEnd.Core.Interfaces
{
    public interface IAuthService
    {
        Task<GeneralServiceResponseDTO> SeedRolesAsync();

        Task<GeneralServiceResponseDTO> RegisterAsync(RegisterDTO registerDTO);

        Task<LoginServiceResponseDTO> LoginAsync(LoginDTO loginDTO);

        Task<GeneralServiceResponseDTO> UpdateRoleAsync(ClaimsPrincipal User,UpdateRoleDTO updateRoleDTO);

        Task<LoginServiceResponseDTO> TokenAsync(TokenDTO tokenDTO);

        Task<IEnumerable<UserInfoResult>> GetUserListAsync();

        Task<UserInfoResult> GetUserDetailsByUserName(string userName);

        Task<IEnumerable<string>> GetUsernamesListAsync();
    }
}
