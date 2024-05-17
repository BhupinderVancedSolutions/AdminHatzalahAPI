using Application.Common.Dtos;
using DTO.Request.ImportantNumber;
using DTO.Response.ImportantNumber;

namespace Application.Abstraction.Repositories
{
    public interface IImportantNumberRepository
    {
        Task<int> CreateUpdateImportantNumber(CreateUpdateImportantNumberRequestDto createUpdateImportantNumberRequestDto);
        Task<bool> IsExistImportantNumber(string Name, int id = 0);
        Task<bool> DeleteImportantNumber(DeleteImportantNumberRequestDto deleteImportantNumberRequestDto);
        Task<(List<GetAllImportantNumberResponseDto>, int)> GetAllImportantNumbers(string filterModel, ServerRowsRequest commonRequest, string getSort);
    }
}
