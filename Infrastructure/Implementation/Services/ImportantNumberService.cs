using Application.Abstraction.Repositories;
using Application.Abstraction.Services;
using Application.Common.Dtos;
using Application.Common.Response;
using DTO.Response;
using DTO.Response.ImportantNumber;
using Helper;

namespace Infrastructure.Implementation.Services
{
    public class ImportantNumberService : IImportantNumberService
    {
        private readonly IImportantNumberRepository _importantNumberRepository;
        public ImportantNumberService(IImportantNumberRepository importantNumberRepository)
        {
            _importantNumberRepository = importantNumberRepository;
        }

        public async Task<CommonResultResponseDto<PaginatedList<GetAllImportantNumberResponseDto>>> GetAllImportantNumbers(string filterModel, ServerRowsRequest commonRequest, string getSort)
        {
            var (numbers, total) = await _importantNumberRepository.GetAllImportantNumbers(filterModel, commonRequest, getSort);
            return CommonResultResponseDto<PaginatedList<GetAllImportantNumberResponseDto>>.Success(new string[] { ActionStatusHelper.Success }, new PaginatedList<GetAllImportantNumberResponseDto>(numbers, total), 0);
        }
    }
}
