using Abp.AspNetCore.Mvc.ViewComponents;

namespace BookingSystem.Web.Views
{
    public abstract class BookingSystemViewComponent : AbpViewComponent
    {
        protected BookingSystemViewComponent()
        {
            LocalizationSourceName = BookingSystemConsts.LocalizationSourceName;
        }
    }
}
