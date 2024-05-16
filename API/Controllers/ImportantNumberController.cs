using Application.Common.Dtos;
using Application.Handler.ImportantNumber.Queries.GetAllImportantNumbers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ImportantNumberController : BaseController
    {
        #region Commands

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
