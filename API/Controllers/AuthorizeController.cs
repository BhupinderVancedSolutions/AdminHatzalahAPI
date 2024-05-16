using Application.Handler.User.Queries.CheckOTP;
using Application.Handler.User.Queries.CheckOTPByUsernameAndPhone;
using Application.Handler.User.Queries.GetTokenByUsername;
using DTO.Request.Authorize;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AuthorizeController : BaseController
    {
        #region Commands

        #endregion

        #region Queries
        [HttpPost]
        [Route("GetTokenByUsername")]
        public async Task<IActionResult> GetTokenByUsername([FromBody] GetTokenByUsernameRequestDto getTokenByUsernameRequestDto)
        {

            var result = await Mediator.Send(getTokenByUsernameRequestDto.Adapt<GetTokenByUsernameQuery>());
            return Ok(result);
        }

        [HttpPost]
        [Route("CheckOTP")]
        public async Task<IActionResult> CheckOTP([FromBody] CheckOTPRequestDto checkOTPRequestDto)
        {
            var result = await Mediator.Send(checkOTPRequestDto.Adapt<CheckOTPQuery>());
            return Ok(result);
        }

        [HttpPost]
        [Route("CheckOTPByUsernameAndPhone")]
        public async Task<IActionResult> CheckOTPByUsernameAndPhone([FromBody] ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            var result = await Mediator.Send(forgotPasswordRequestDto.Adapt<CheckOTPByUsernameAndPhoneQuery>());
            return Ok(result);
        }
        #endregion

    }
}
