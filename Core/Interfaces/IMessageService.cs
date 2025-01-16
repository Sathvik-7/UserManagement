using System.Security.Claims;
using UserManagement.BackEnd.Core.DTO.General;
using UserManagement.BackEnd.Core.DTO.Message;

namespace UserManagement.BackEnd.Core.Interfaces
{
    public interface IMessageService
    {
        Task<GeneralServiceResponseDTO> CreateNewMessgeAsync(ClaimsPrincipal User,CreateMessageDTO createMessageDTO);

        Task<IEnumerable<GetMessageDTO>> GetMessagesAsync();

        Task<IEnumerable<GetMessageDTO>> GetMyMessageAsync(ClaimsPrincipal User);
    }
}
