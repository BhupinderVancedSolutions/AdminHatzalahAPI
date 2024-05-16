using Application.Abstraction.DataBase;
using Application.Abstraction.Repositories;
using Application.Common.Dtos;
using Dapper;
using DTO.Response.ImportantNumber;
using System.Data;

namespace Infrastructure.Implementation.Repositories
{
    public class ImportantNumberRepository: IImportantNumberRepository
    {
        private readonly IDbContext _dbContext;
        private readonly IParameterManager _parameterManager;
        public ImportantNumberRepository(IDbContext dbContext, IParameterManager parameterManager)
        {
            _dbContext = dbContext;
            _parameterManager = parameterManager;
        }

        public async Task<(List<GetAllImportantNumberResponseDto>, int)> GetAllImportantNumbers(string filterModel, ServerRowsRequest commonRequest, string getSort)
        {
            List<GetAllImportantNumberResponseDto> numbers;
            int total = 0;
            using (var dbConnection = _dbContext.GetDbConnection())
            {
                var result = await dbConnection.QueryMultipleAsync(
            "usp_GetAllImportantNumber", _dbContext.GetDapperDynamicParameters
            (_parameterManager.Get("@StartRow", commonRequest.StartRow),
              _parameterManager.Get("@EndRow", commonRequest.EndRow),
              _parameterManager.Get("@FilterModel", filterModel),
              _parameterManager.Get("@OrderBy", getSort),
              _parameterManager.Get("@SearchText", commonRequest.SearchText)
            ),
            commandType: CommandType.StoredProcedure);
                total = result.Read<int>().FirstOrDefault();
                numbers = result.Read<GetAllImportantNumberResponseDto>().ToList();
                dbConnection.Close();
            }
            return (numbers, total);
        }
    }
}
