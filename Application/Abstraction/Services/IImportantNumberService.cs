using Application.Common.Dtos;
using Application.Common.Response;
using DTO.Response.ImportantNumber;
using DTO.Response;
using DTO.Request.ImportantNumber;

namespace Application.Abstraction.Services
{
    public interface IImportantNumberService
    {
        Task<CommonResultResponseDto<CreateUpdateImportantNumberResponseDto>> CreateUpdateImportantNumber(CreateUpdateImportantNumberRequestDto createUpdateImportantNumberRequestDto);
        Task<CommonResultResponseDto<PaginatedList<GetAllImportantNumberResponseDto>>> GetAllImportantNumbers(string filterModel, ServerRowsRequest commonRequest, string getSort);
        Task<CommonResultResponseDto<string>> DeleteImportantNumber(DeleteImportantNumberRequestDto deleteImportantNumberRequestDto);
    }
}
