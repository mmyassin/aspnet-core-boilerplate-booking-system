using Abp.Application.Services.Dto;
using System;

namespace BookingSystem.Jets.Dtos
{
    public class GetAllJetsInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public int IsActiveFilter { get; set; }



    }
}