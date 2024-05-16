
using Domain.Entities;
using DTO.Response;
using MediatR;

namespace Application.Handler.User.Queries.CheckOTPByUsernameAndPhone
{
    public class CheckOTPByUsernameAndPhoneQuery : IRequest<CommonResultResponseDto<Users>>
    {
        public string Username { get; set; }
        public string Phone { get; set; }
    }
}
