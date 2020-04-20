
using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace BookingSystem.Cities.Dtos
{
	[AutoMapFrom(typeof(City))]
    public class CityDto : EntityDto
    {
		public string Code { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public string Country { get; set; }



    }
}