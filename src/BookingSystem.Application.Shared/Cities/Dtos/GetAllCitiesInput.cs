using Abp.Application.Services.Dto;
using System;

namespace BookingSystem.Cities.Dtos
{
    public class GetAllCitiesInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }



    }
}