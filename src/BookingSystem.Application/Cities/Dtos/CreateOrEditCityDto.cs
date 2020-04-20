
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace BookingSystem.Cities.Dtos
{
	[AutoMapFrom(typeof(City))]
	[AutoMapTo(typeof(City))]
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