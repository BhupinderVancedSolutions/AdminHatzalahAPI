using Domain.Entities;
using DTO.Response;
using MediatR;

namespace Application.Handler.User.Queries.CheckOTP
{
    public class CheckOTPQuery : IRequest<CommonResultResponseDto<Users>>
    {
        public string Username { get; set; }
        public string Phone { get; set; }
        public int Otp { get; set; }
    }
}
