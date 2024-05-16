using Application.Abstraction.Repositories;
using Application.Abstraction.Services;
using Application.Settings;
using Domain.Entities;
using DTO.Response;
using DTO.Response.User;
using Helper;
using Mapster;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Implementation.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly AppSettings _appSettings;
        public UserService(IUserRepository userRepository, IOptions<AppSettings> appSettings)
        {
            _userRepository = userRepository;
            _appSettings = appSettings.Value;

        }

        public async Task<CommonResultResponseDto<Users>> CheckOTP(string username, string phone, int otp)
        {
            var checkOTP = await _userRepository.CheckOTP(username, phone, otp);
            if (checkOTP != null)
            {
                if (checkOTP.UpdatedDate < DateTime.Now.AddMinutes(-3))
                {
                    return CommonResultResponseDto<Users>.Failure(new string[] { "OTP is expired" }, checkOTP);
                }
                return CommonResultResponseDto<Users>.Success(new string[] { ActionStatusHelper.Success }, checkOTP);
            }
            return CommonResultResponseDto<Users>.Failure(new string[] { "Could not find a valid OTP" }, checkOTP);
        }


        public async Task<CommonResultResponseDto<UserAndTokenResponseDto>> GetTokenByUsername(string userName, string password)
        {
            var user = await _userRepository.GetTokenByUsername(userName, password);
            if (user != null)
            {
                Users userData = user;

                Tokens token = new Tokens();
                var tokenData = await _userRepository.GetTokenByUserId(user.Id);
                if (tokenData != null)
                {
                    token = tokenData;
                }
                token.UserID = user.Id;
                JWTToken jwtToken = await CreateJWTToken(user.Adapt<Users>());
                token.Token = jwtToken.Token;
                token.Expiration = jwtToken.Expiration;
                token.RefreshTokenEndDate = jwtToken.Expiration.AddMonths(1);
                //tokenBusiness.UpsertToken(token);
                //var tokens = await _userRepository.UpsertToken(token);

                UserAndTokenResponseDto userAndTokenDto = new UserAndTokenResponseDto
                {
                    Tokens = token,
                    UserInfoDto = new UserInfoDto
                    {
                        UserFullName = user.FirstName + " " + user.LastName,
                        EMail = user.Email,
                        Phone = user.Phone,
                        userName = user.Username,
                        roleId = user.SysRolesId
                    },
                    //Permissions = permissions
                };
                return CommonResultResponseDto<UserAndTokenResponseDto>.Success(new string[] { ActionStatusHelper.Success }, userAndTokenDto);
            }
            else
            {
                return CommonResultResponseDto<UserAndTokenResponseDto>.Failure(new string[] { "Username or password incorrect!" }, null);
            }
        }


        public async Task<CommonResultResponseDto<Users>> CheckOTPByUsernameAndPhone(string username, string phone)
        {
            var checkOTPByUsernameAndPhone = await _userRepository.CheckOTPByUsernameAndPhone(username, phone);
            if (checkOTPByUsernameAndPhone != null)
            {
                int OTPCode = new Random().Next(100000, 999999);
                Users user = checkOTPByUsernameAndPhone;
                user.OtpCode = OTPCode;
                user.UpdatedDate = DateTime.Now;
                Users BRCUsers = await _userRepository.GetUserByUserId(checkOTPByUsernameAndPhone.Id);
                if (checkOTPByUsernameAndPhone.Id != 0)
                {
                    Users users = BRCUsers;
                    ValidateResponseDto<Users> validate = UserValidateRole(checkOTPByUsernameAndPhone);
                    if (validate.IsValid)
                    {
                        users.SysRolesId = checkOTPByUsernameAndPhone.SysRolesId;
                        users.UpdatedDate = DateTime.Now;
                        users.OtpCode = checkOTPByUsernameAndPhone.OtpCode;

                        if (checkOTPByUsernameAndPhone.Password != null)
                        {
                            users.Password = checkOTPByUsernameAndPhone.Password;
                        }
                        await _userRepository.UpdateOTPByUsernameAndPhone(users);
                    }
                    else
                        return CommonResultResponseDto<Users>.Success(new string[] { validate.Message }, checkOTPByUsernameAndPhone);
                }

                string body = "Your Hatzalah OTP code is: " + OTPCode.ToString().Substring(0, 3) + "-" + OTPCode.ToString().Substring(3, 3);
                //MessageResource message = await TwilioService.SendNotification(body, Phone);
                //if (message != null && message?.ErrorCode.HasValue == true)
                //{
                //    return CommonResultResponseDto<Users>.Failure(new string[] { "Failure: " + message.ErrorCode + " " + message.ErrorMessage }, checkOTPByUsernameAndPhone);
                //}
                return CommonResultResponseDto<Users>.Success(new string[] { ActionStatusHelper.Success }, checkOTPByUsernameAndPhone);

            }
            return CommonResultResponseDto<Users>.Failure(new string[] { "Could not find a valid user" }, checkOTPByUsernameAndPhone);
        }

        #region Private
        private async Task<JWTToken> CreateJWTToken(Users user)
        {
            byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            DateTime expires = DateTime.Now.AddHours(12);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = expires,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenString = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
            var result = user.Adapt<JWTToken>();
            result.Expiration = expires;
            result.Token = tokenString;
            return result;
        }
        private ValidateResponseDto<Users> UserValidateRole(Users user)
        {
            ValidateResponseDto<Users> userValidateRole = new ValidateResponseDto<Users>();

            if (user.SysRolesId <= 0)
            {
                userValidateRole.Message = "Role is required!";
            }
            else
            {
                userValidateRole.IsValid = true;
            }

            return userValidateRole;
        }
        #endregion
    }

}
