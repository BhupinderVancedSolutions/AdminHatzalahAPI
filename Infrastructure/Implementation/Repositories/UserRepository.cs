using Application.Abstraction.DataBase;
using Application.Abstraction.Repositories;
using Dapper;
using Domain.Entities;
using DTO.Request.User;
using System.Data;

namespace Infrastructure.Implementation.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContext _dbContext;
        private readonly IParameterManager _parameterManager;
        public UserRepository(IDbContext dbContext, IParameterManager parameterManager)
        {
            _dbContext = dbContext;
            _parameterManager = parameterManager;
        }
        public async Task<Users> GetTokenByUsername(string userName, string password)
        {
            return await _dbContext.ExecuteStoredProcedure<Users>("usp_GetTokenByUsername",
                 _parameterManager.Get("@UserName", userName),
                 _parameterManager.Get("@Password", password));
        }

        public async Task<Tokens> GetTokenByUserId(int userId)
        {
            return await _dbContext.ExecuteStoredProcedure<Tokens>("usp_GetTokensByUserId",
                _parameterManager.Get("@UserId", userId));
        }

        public async Task<RolePermissionsRequestDto> GetByRoleId(int roleId)
        {
            RolePermissionsRequestDto admin = new RolePermissionsRequestDto();
            List<RolePermissionsRequest> data;
            int total;
            using (var dbConnection = _dbContext.GetDbConnection())
            {
                var result = await dbConnection.QueryMultipleAsync(
                   "usp_GetAllRolePermissions", _dbContext.GetDapperDynamicParameters
                  (_parameterManager.Get("@RoleId", roleId)),

                  commandType: CommandType.StoredProcedure);
                data = result.Read<RolePermissionsRequest>().ToList();
                dbConnection.Close();
                admin.Data = data;
            }
            return admin;
        }

        public async Task<List<Permissions>> GetAllAsListByPermissionIds(List<int> permissionIdList)
        {
            List<Permissions> data;
            var permissionIdListParameter = string.Join(",", permissionIdList);
            using (var dbConnection = _dbContext.GetDbConnection())
            {

                var result = await dbConnection.QueryMultipleAsync(
                   "usp_GetPermissionsByIdList", _dbContext.GetDapperDynamicParameters
                  (_parameterManager.Get("@PermissionIdList", permissionIdListParameter)),

                  commandType: CommandType.StoredProcedure);
                data = result.Read<Permissions>().ToList();
                dbConnection.Close();
            }
            return data;
        }

        public async Task<Users> CheckOTP(string username, string phone, int otp)
        {
            return await _dbContext.ExecuteStoredProcedure<Users>("usp_CheckOTP",
             _parameterManager.Get("@Username", username),
            _parameterManager.Get("@Phone", phone),
             _parameterManager.Get("@OTP", otp));
        }

        public async Task<Users> CheckOTPByUsernameAndPhone(string username, string phone)
        {
            return await _dbContext.ExecuteStoredProcedure<Users>("usp_CheckOTP",
             _parameterManager.Get("@Username", username),
             _parameterManager.Get("@Phone", phone));
        }

        public async Task<Users> GetUserByUserId(int id)
        {
            return await _dbContext.ExecuteStoredProcedure<Users>("usp_GetUserByUserId",
                _parameterManager.Get("@UserId", id));
        }

        public async Task<Users> UpdateOTPByUsernameAndPhone(Users users)
        {
            return await _dbContext.ExecuteStoredProcedure<Users>("usp_UpdateOTPByUsernameAndPhone",
               _parameterManager.Get("@SysRolesId", users.SysRolesId),
               _parameterManager.Get("@UserName", users.Username),
               _parameterManager.Get("@Phone", users.Phone),
               _parameterManager.Get("@Password", users.Password),
               _parameterManager.Get("@OtpCode", users.OtpCode));
        }
    }
}
