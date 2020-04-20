
using System;
using Abp.Application.Services.Dto;

namespace BookingSystem.Cities.Dtos
{
    public class CityDto : EntityDto
    {
		public string Code { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public string Country { get; set; }



    }
}