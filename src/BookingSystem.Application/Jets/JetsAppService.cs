

using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using BookingSystem.Jets.Dtos;
using BookingSystem.Dto;
using Abp.Application.Services.Dto;
using BookingSystem.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Jets
{
	[AbpAuthorize(AppPermissions.Pages_Jets)]
    public class JetsAppService : BookingSystemAppServiceBase, IJetsAppService
    {
		 private readonly IRepository<Jet> _jetRepository;
		 

		  public JetsAppService(IRepository<Jet> jetRepository ) 
		  {
			_jetRepository = jetRepository;
			
		  }

		 public async Task<PagedResultDto<GetJetForViewDto>> GetAll(GetAllJetsInput input)
         {
			
			var filteredJets = _jetRepository.GetAll()
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.JetType.Contains(input.Filter))
						.WhereIf(input.IsActiveFilter > -1,  e => (input.IsActiveFilter == 1 && e.IsActive) || (input.IsActiveFilter == 0 && !e.IsActive) );

			var pagedAndFilteredJets = filteredJets
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

			var jets = from o in pagedAndFilteredJets
                         select new GetJetForViewDto() {
							Jet = new JetDto
							{
                                JetType = o.JetType,
                                TotalCapacity = o.TotalCapacity,
                                IsActive = o.IsActive,
                                Id = o.Id
							}
						};

            var totalCount = await filteredJets.CountAsync();

            return new PagedResultDto<GetJetForViewDto>(
                totalCount,
                await jets.ToListAsync()
            );
         }
		 
		 public async Task<GetJetForViewDto> GetJetForView(int id)
         {
            var jet = await _jetRepository.GetAsync(id);

            var output = new GetJetForViewDto { Jet = ObjectMapper.Map<JetDto>(jet) };
			
            return output;
         }
		 
		 [AbpAuthorize(AppPermissions.Pages_Jets_Edit)]
		 public async Task<GetJetForEditOutput> GetJetForEdit(EntityDto input)
         {
            var jet = await _jetRepository.FirstOrDefaultAsync(input.Id);
           
		    var output = new GetJetForEditOutput {Jet = ObjectMapper.Map<CreateOrEditJetDto>(jet)};
			
            return output;
         }

		 public async Task CreateOrEdit(CreateOrEditJetDto input)
         {
            if(input.Id == null){
				await Create(input);
			}
			else{
				await Update(input);
			}
         }

		 [AbpAuthorize(AppPermissions.Pages_Jets_Create)]
		 protected virtual async Task Create(CreateOrEditJetDto input)
         {
            var jet = ObjectMapper.Map<Jet>(input);

			
			if (AbpSession.TenantId != null)
			{
				jet.TenantId = (int) AbpSession.TenantId;
			}
		

            await _jetRepository.InsertAsync(jet);
         }

		 [AbpAuthorize(AppPermissions.Pages_Jets_Edit)]
		 protected virtual async Task Update(CreateOrEditJetDto input)
         {
            var jet = await _jetRepository.FirstOrDefaultAsync((int)input.Id);
             ObjectMapper.Map(input, jet);
         }

		 [AbpAuthorize(AppPermissions.Pages_Jets_Delete)]
         public async Task Delete(EntityDto input)
         {
            await _jetRepository.DeleteAsync(input.Id);
         } 
    }
}