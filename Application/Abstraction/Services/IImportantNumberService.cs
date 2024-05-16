using Application.Common.Dtos;
using Application.Common.Response;
using DTO.Response.ImportantNumber;
using DTO.Response;

namespace Application.Abstraction.Services
{
    public interface IImportantNumberService
    {
        Task<CommonResultResponseDto<PaginatedList<GetAllImportantNumberResponseDto>>> GetAllImportantNumbers(string filterModel, ServerRowsRequest commonRequest, string getSort);
    }
}
