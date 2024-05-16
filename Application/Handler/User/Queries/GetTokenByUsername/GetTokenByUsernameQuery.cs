using DTO.Response;
using DTO.Response.User;
using MediatR;

namespace Application.Handler.User.Queries.GetTokenByUsername
{
    public class GetTokenByUsernameQuery : IRequest<CommonResultResponseDto<UserAndTokenResponseDto>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
