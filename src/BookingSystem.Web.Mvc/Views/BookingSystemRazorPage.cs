using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace BookingSystem.Web.Views
{
    public abstract class BookingSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BookingSystemRazorPage()
        {
            LocalizationSourceName = BookingSystemConsts.LocalizationSourceName;
        }
    }
}
