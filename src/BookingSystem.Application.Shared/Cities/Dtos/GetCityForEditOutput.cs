using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Cities.Dtos
{
    public class GetCityForEditOutput
    {
		public CreateOrEditCityDto City { get; set; }


    }
}