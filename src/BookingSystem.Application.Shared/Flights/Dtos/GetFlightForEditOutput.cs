using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Flights.Dtos
{
    public class GetFlightForEditOutput
    {
		public CreateOrEditFlightDto Flight { get; set; }

		public string CityName { get; set;}

		public string CityName2 { get; set;}

		public string JetJetType { get; set;}


    }
}