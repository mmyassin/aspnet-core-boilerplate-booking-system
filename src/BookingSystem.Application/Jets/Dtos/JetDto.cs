
using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace BookingSystem.Jets.Dtos
{
    [AutoMapFrom(typeof(Jet))]
    public class JetDto : EntityDto
    {
		public string JetType { get; set; }

		public int TotalCapacity { get; set; }

		public bool IsActive { get; set; }
    }
}