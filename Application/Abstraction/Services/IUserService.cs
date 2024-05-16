using DTO.Response.User;
using DTO.Response;
using Domain.Entities;

namespace Application.Abstraction.Services
{
    public interface IUserService
    {
        Task<CommonResultResponseDto<UserAndTokenResponseDto>> GetTokenByUsername(string userName, string password);
        Task<CommonResultResponseDto<Users>> CheckOTP(string username, string phone, int otp);
        Task<CommonResultResponseDto<Users>> CheckOTPByUsernameAndPhone(string username, string phone);
    }
}
