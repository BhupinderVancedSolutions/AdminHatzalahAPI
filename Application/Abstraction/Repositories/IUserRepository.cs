using DTO.Response.User;
using DTO.Response;
using Domain.Entities;
using DTO.Request.User;

namespace Application.Abstraction.Repositories
{
    public interface IUserRepository
    {
        Task<Users> GetTokenByUsername(string userName, string password);
        Task<Tokens> GetTokenByUserId(int userId);
        Task<RolePermissionsRequestDto> GetByRoleId(int roleId);
        Task<List<Permissions>> GetAllAsListByPermissionIds(List<int> permissionIdList);
        Task<Users> CheckOTP(string username, string phone, int otp);
        Task<Users> CheckOTPByUsernameAndPhone(string username, string phone);
        Task<Users> GetUserByUserId(int id);
        Task<Users> UpdateOTPByUsernameAndPhone(Users users);
    }
}
