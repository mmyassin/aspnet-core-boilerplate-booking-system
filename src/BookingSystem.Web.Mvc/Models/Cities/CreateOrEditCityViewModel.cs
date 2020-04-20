using BookingSystem.Cities.Dtos;

using Abp.Extensions;

namespace BookingSystem.Web.Models.Cities
{
    public class CreateOrEditCityModalViewModel
    {
       public CreateOrEditCityDto City { get; set; }

	   
       
	   public bool IsEditMode => City.Id.HasValue;
    }
}