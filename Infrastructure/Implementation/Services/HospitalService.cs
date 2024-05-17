 
using Application.Abstraction.Services; 
using DTO.Response;  
 
using Helper;
using Application.Common.Response;
using DTO.Response.Hospitals;
using Application.Common.Dtos;
using Application.Abstraction.Repositories;
using DTO.Request.Hospitals;

namespace Infrastructure.Implementation.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IHospitalRepository _hospitalRepository ;
        
      
        public HospitalService(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
           
        }
        public async Task<CommonResultResponseDto<CreateUpdateHospitalResponseDto>> CreateUpdateHospital(CreateUpdateHospitalRequestDto createUpdateHospitalRequestDto)
        {
            var returnvalue = await _hospitalRepository.IsExistHospital(createUpdateHospitalRequestDto.Name, createUpdateHospitalRequestDto.Id);
            if (returnvalue == true)
            {
                return CommonResultResponseDto<CreateUpdateHospitalResponseDto>.Failure(new string[] { ActionStatusHelper.IsExistName }, null);
            }
            else
            {
                var hospital = await _hospitalRepository.CreateUpdateHospital(createUpdateHospitalRequestDto);

                if (hospital == 0)
                {
                    return CommonResultResponseDto<CreateUpdateHospitalResponseDto>.Success(new string[] { ActionStatusHelper.Created }, null, 0);
                }
                else
                {
                    return CommonResultResponseDto<CreateUpdateHospitalResponseDto>.Success(new string[] { ActionStatusHelper.Updated }, null, 0);
                }
            }
        }

        public async Task<CommonResultResponseDto<string>> DeleteHospital(int id)
        {
            bool result = await _hospitalRepository.DeleteHospital(id);
            if (result)
            {
                return CommonResultResponseDto<string>.Success(new string[] { ActionStatusHelper.Deleted }, null, 0);
            }
            else
            {
                return CommonResultResponseDto<string>.Failure(new string[] { ActionStatusHelper.Error }, null);
            }
        }

        public async Task<CommonResultResponseDto<PaginatedList<HospitalsResponseDto>>> GetAllHospitals(string filterModel, ServerRowsRequest commonRequest, string getSort)
        {
            var (hospitals, total) = await _hospitalRepository.GetAllHospitals(filterModel, commonRequest, getSort);
            return CommonResultResponseDto<PaginatedList<HospitalsResponseDto>>.Success(new string[] { ActionStatusHelper.Success }, new PaginatedList<HospitalsResponseDto>(hospitals, total), 0);
        }
 
    }
}
