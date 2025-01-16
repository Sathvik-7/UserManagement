using System.Security.Claims;
using UserManagement.BackEnd.Core.DTO.Log;

namespace UserManagement.BackEnd.Core.Interfaces
{
    public interface ILogService
    {
        Task SaveNewLog(string UserName, string Description);

        Task<IEnumerable<GetLogDTO>> GetLogsAsync();

        Task<IEnumerable<GetLogDTO>> GetMyLogAsync(ClaimsPrincipal User);
    }
}
