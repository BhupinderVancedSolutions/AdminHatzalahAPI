using Application.Common.Dtos;
using DTO.Response.ImportantNumber;

namespace Application.Abstraction.Repositories
{
    public interface IImportantNumberRepository
    {
        Task<(List<GetAllImportantNumberResponseDto>, int)> GetAllImportantNumbers(string filterModel, ServerRowsRequest commonRequest, string getSort);
    }
}
