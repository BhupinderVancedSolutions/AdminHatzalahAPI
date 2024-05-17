using Application.Abstraction.DataBase;
using Application.Abstraction.Repositories;
using Application.Common.Dtos;
using Dapper;
using DTO.Request.Hospitals;
using DTO.Response.Hospitals;
using System.Data;

namespace Infrastructure.Implementation.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly IDbContext _dbContext;
        private readonly IParameterManager _parameterManager;

        public HospitalRepository(IDbContext dbContext, IParameterManager parameterManager)
        {
            _dbContext = dbContext;
            _parameterManager = parameterManager;
        }

        public async Task<int> CreateUpdateHospital(CreateUpdateHospitalRequestDto createUpdateHospitalRequestDto)
        {
            return await _dbContext.ExecuteStoredProcedure<int>("usp_CreateUpdateHospital",
             _parameterManager.Get("@Id", createUpdateHospitalRequestDto.Id),
             _parameterManager.Get("@Name", createUpdateHospitalRequestDto.Name),
             _parameterManager.Get("@Address", createUpdateHospitalRequestDto.Address),
             _parameterManager.Get("@City", createUpdateHospitalRequestDto.City),
             _parameterManager.Get("@State", createUpdateHospitalRequestDto.State),
             _parameterManager.Get("@Zip", createUpdateHospitalRequestDto.Zip),
             _parameterManager.Get("@FacilityType", createUpdateHospitalRequestDto.FacilityType),
             _parameterManager.Get("@DispositionCode", createUpdateHospitalRequestDto.DispositionCode),
             _parameterManager.Get("@CityCode", createUpdateHospitalRequestDto.CityCode),
             _parameterManager.Get("@MainPhone", createUpdateHospitalRequestDto.MainPhone),
             _parameterManager.Get("@ERPhone", createUpdateHospitalRequestDto.ErPhone),
             _parameterManager.Get("@ERFax", createUpdateHospitalRequestDto.ErFax),
             _parameterManager.Get("@PedsERFax", createUpdateHospitalRequestDto.PedsErFax),
             _parameterManager.Get("@AltFax", createUpdateHospitalRequestDto.AltFax),
             _parameterManager.Get("@LD", createUpdateHospitalRequestDto.Ld),
             _parameterManager.Get("@Nickname", createUpdateHospitalRequestDto.Nickname),
             _parameterManager.Get("@Latitude", createUpdateHospitalRequestDto.Latitude),
             _parameterManager.Get("@Longitude", createUpdateHospitalRequestDto.Longitude),
             _parameterManager.Get("@RowNumber", createUpdateHospitalRequestDto.RowNumber)
             //_parameterManager.Get("@IsTopUsed", createUpdateHospitalRequestDto.IsTopUsed)
             );
        }

        public async Task<bool> DeleteHospital(int id)
        {
            return await _dbContext.ExecuteStoredProcedure<bool>("usp_DeleteHospital",
          _parameterManager.Get("@Id", id));
        }

        public async Task<(List<HospitalsResponseDto>, int)> GetAllHospitals(string filterModel, ServerRowsRequest commonRequest, string getSort)
        {
            List<HospitalsResponseDto> approvalMembers;
            int total = 0;
            using (var dbConnection = _dbContext.GetDbConnection())
            {
                var result = await dbConnection.QueryMultipleAsync(
            "usp_GetAllHospitals", _dbContext.GetDapperDynamicParameters
            (_parameterManager.Get("@StartRow", commonRequest.StartRow),
              _parameterManager.Get("@EndRow", commonRequest.EndRow),
              _parameterManager.Get("@FilterModel", filterModel),
              _parameterManager.Get("@OrderBy", getSort),
              _parameterManager.Get("@SearchText", commonRequest.SearchText)
            ),
            commandType: CommandType.StoredProcedure);
                total = result.Read<int>().FirstOrDefault();
                approvalMembers = result.Read<HospitalsResponseDto>().ToList();
                dbConnection.Close();
            }
            return (approvalMembers, total);
        }

        public async Task<bool> IsExistHospital(string name, int id = 0)
        {
            return await _dbContext.ExecuteStoredProcedure<bool>("usp_IsExistHospital",
           _parameterManager.Get("@Id", id),
           _parameterManager.Get("@Name", name));
        }
    }
}
