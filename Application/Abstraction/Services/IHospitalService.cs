using Application.Common.Dtos;
using Application.Common.Response;
using DTO.Request.Hospitals;
using DTO.Response; 
using DTO.Response.Hospitals;

namespace Application.Abstraction.Services
{
    public interface IHospitalService
    {
        Task<CommonResultResponseDto<CreateUpdateHospitalResponseDto>> CreateUpdateHospital(CreateUpdateHospitalRequestDto createUpdateHospitalRequestDto);
        Task<CommonResultResponseDto<PaginatedList<HospitalsResponseDto>>> GetAllHospitals(string filterModel, ServerRowsRequest commonRequest, string getSort);
        Task<CommonResultResponseDto<string>> DeleteHospital(int id);
    }
}
