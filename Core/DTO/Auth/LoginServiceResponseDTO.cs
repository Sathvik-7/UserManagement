namespace UserManagement.BackEnd.Core.DTO.Auth
{
    public class LoginServiceResponseDTO
    {

        public string NewToken { get; set; }

        public UserInfoResult UserInfo { get; set; }


    }
}
