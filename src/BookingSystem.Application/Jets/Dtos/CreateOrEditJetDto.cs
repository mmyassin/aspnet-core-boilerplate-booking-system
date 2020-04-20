
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace BookingSystem.Jets.Dtos
{
	[AutoMapFrom(typeof(Jet))]
	[AutoMapTo(typeof(Jet))]
	public class CreateOrEditJetDto : EntityDto<int?>
    {

		[Required]
		public string JetType { get; set; }
		
		
		public int TotalCapacity { get; set; }
		
		
		public bool IsActive { get; set; }
		
		

    }
}