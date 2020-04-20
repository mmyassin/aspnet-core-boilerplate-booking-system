using BookingSystem.Jets.Dtos;

using Abp.Extensions;

namespace BookingSystem.Web.Models.Jets
{
    public class CreateOrEditJetModalViewModel
    {
       public CreateOrEditJetDto Jet { get; set; }

	   
       
	   public bool IsEditMode => Jet.Id.HasValue;
    }
}