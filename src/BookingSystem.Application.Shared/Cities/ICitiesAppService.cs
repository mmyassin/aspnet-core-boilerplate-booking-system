using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookingSystem.Cities.Dtos;
using BookingSystem.Dto;


namespace BookingSystem.Cities
{
    public interface ICitiesAppService : IApplicationService 
    {
        Task<PagedResultDto<GetCityForViewDto>> GetAll(GetAllCitiesInput input);

        Task<GetCityForViewDto> GetCityForView(int id);

		Task<GetCityForEditOutput> GetCityForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditCityDto input);

		Task Delete(EntityDto input);

		
    }
}