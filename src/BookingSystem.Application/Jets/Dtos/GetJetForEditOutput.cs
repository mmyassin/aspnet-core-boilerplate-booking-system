using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Jets.Dtos
{
    public class GetJetForEditOutput
    {
		public CreateOrEditJetDto Jet { get; set; }


    }
}