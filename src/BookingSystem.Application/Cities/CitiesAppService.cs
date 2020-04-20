

using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using BookingSystem.Cities.Dtos;
using BookingSystem.Dto;
using Abp.Application.Services.Dto;
using BookingSystem.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Cities
{
	[AbpAuthorize(AppPermissions.Pages_Cities)]
    public class CitiesAppService : BookingSystemAppServiceBase, ICitiesAppService
    {
		 private readonly IRepository<City> _cityRepository;
		 

		  public CitiesAppService(IRepository<City> cityRepository ) 
		  {
			_cityRepository = cityRepository;
			
		  }

		 public async Task<PagedResultDto<GetCityForViewDto>> GetAll(GetAllCitiesInput input)
         {
			
			var filteredCities = _cityRepository.GetAll()
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.Code.Contains(input.Filter) || e.Name.Contains(input.Filter) || e.DisplayName.Contains(input.Filter) || e.Country.Contains(input.Filter));

			var pagedAndFilteredCities = filteredCities
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

			var cities = from o in pagedAndFilteredCities
                         select new GetCityForViewDto() {
							City = new CityDto
							{
                                Code = o.Code,
                                Name = o.Name,
                                DisplayName = o.DisplayName,
                                Country = o.Country,
                                Id = o.Id
							}
						};

            var totalCount = await filteredCities.CountAsync();

            return new PagedResultDto<GetCityForViewDto>(
                totalCount,
                await cities.ToListAsync()
            );
         }
		 
		 public async Task<GetCityForViewDto> GetCityForView(int id)
         {
            var city = await _cityRepository.GetAsync(id);

            var output = new GetCityForViewDto { City = ObjectMapper.Map<CityDto>(city) };
			
            return output;
         }
		 
		 [AbpAuthorize(AppPermissions.Pages_Cities_Edit)]
		 public async Task<GetCityForEditOutput> GetCityForEdit(EntityDto input)
         {
            var city = await _cityRepository.FirstOrDefaultAsync(input.Id);
           
		    var output = new GetCityForEditOutput {City = ObjectMapper.Map<CreateOrEditCityDto>(city)};
			
            return output;
         }

		 public async Task CreateOrEdit(CreateOrEditCityDto input)
         {
            if(input.Id == null){
				await Create(input);
			}
			else{
				await Update(input);
			}
         }

		 [AbpAuthorize(AppPermissions.Pages_Cities_Create)]
		 protected virtual async Task Create(CreateOrEditCityDto input)
         {
            var city = ObjectMapper.Map<City>(input);

			
			if (AbpSession.TenantId != null)
			{
				city.TenantId = (int) AbpSession.TenantId;
			}
		

            await _cityRepository.InsertAsync(city);
         }

		 [AbpAuthorize(AppPermissions.Pages_Cities_Edit)]
		 protected virtual async Task Update(CreateOrEditCityDto input)
         {
            var city = await _cityRepository.FirstOrDefaultAsync((int)input.Id);
             ObjectMapper.Map(input, city);
         }

		 [AbpAuthorize(AppPermissions.Pages_Cities_Delete)]
         public async Task Delete(EntityDto input)
         {
            await _cityRepository.DeleteAsync(input.Id);
         } 
    }
}