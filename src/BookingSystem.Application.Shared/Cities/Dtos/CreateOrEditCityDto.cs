
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Cities.Dtos
{
    public class CreateOrEditCityDto : EntityDto<int?>
    {

		[Required]
		public string Code { get; set; }
		
		
		[Required]
		public string Name { get; set; }
		
		
		public string DisplayName { get; set; }
		
		
		public string Country { get; set; }
		
		

    }
}