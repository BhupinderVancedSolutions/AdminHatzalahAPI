using Application.Common.Dtos;
using Application.Handler.ImportantNumber.Command.DeleteImportantNumber;
using Application.Handler.ImportantNumber.Command.UpsertImportantNumber;
using Application.Handler.ImportantNumber.Queries.GetAllImportantNumbers;
using DTO.Request.ImportantNumber;
using DTO.Response;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ImportantNumberController : BaseController
    {
        #region Commands
        [HttpPost]
        [Route("CreateUpdateImportantNumber")]
        public async Task<IActionResult> CreateUpdateImportantNumber([FromBody] CreateUpdateImportantNumberRequestDto createUpdateImportantNumberRequestDto)
        {
            var result = await Mediator.Send(createUpdateImportantNumberRequestDto.Adapt<CreateUpdateImportantNumberCommand>());
            return Ok(result);
        }
        [HttpPost]
        [Route("DeleteImportantNumber")]
        public async Task<IActionResult> DeleteImportantNumber([FromQuery] DeleteImportantNumberRequestDto deleteImportantNumberRequestDto)
        {
            CommonResultResponseDto<string> result = await Mediator.Send(deleteImportantNumberRequestDto.Adapt<DeleteImportantNumberCommand>());
            return Ok(result);
        }
        #endregion

        #region Queries
        [HttpPost]
        [Route("GetAllImportantNumbers")]
        public async Task<IActionResult> GetAllImportantNumbers([FromBody] ServerRowsRequest commonRequest)
        {
            var result = await Mediator.Send(new GetAllImportantNumbersQuery { CommonRequest = commonRequest });
            return Ok(result);
        }
        #endregion
    }
}
