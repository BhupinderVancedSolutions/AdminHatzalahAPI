using Application.Common.Dtos;
using DTO.Request.Hospitals;
using DTO.Response.Hospitals;

namespace Application.Abstraction.Repositories
{
    public interface IHospitalRepository
    {
        Task<(List<HospitalsResponseDto>, int)> GetAllHospitals(string filterModel, ServerRowsRequest commonRequest, string getSort);
        Task<bool> IsExistHospital(string name, int id = 0);
        Task<int> CreateUpdateHospital(CreateUpdateHospitalRequestDto createUpdateHospitalRequestDto);
        Task<bool> DeleteHospital(int id);
    }
}
