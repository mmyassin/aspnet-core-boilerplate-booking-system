using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookingSystem.Jets.Dtos;
using BookingSystem.Dto;


namespace BookingSystem.Jets
{
    public interface IJetsAppService : IApplicationService 
    {
        Task<PagedResultDto<GetJetForViewDto>> GetAll(GetAllJetsInput input);

        Task<GetJetForViewDto> GetJetForView(int id);

		Task<GetJetForEditOutput> GetJetForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditJetDto input);

		Task Delete(EntityDto input);

		
    }
}