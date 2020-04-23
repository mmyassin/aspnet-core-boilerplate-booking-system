using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using BookingSystem.Authorization.Roles;
using System.Collections.Generic;

namespace BookingSystem.Authorization
{
    public class AppAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public AppAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public AppAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            var flights = pages.CreateChildPermission(AppPermissions.Pages_Flights, L("Flights"), multiTenancySides: MultiTenancySides.Tenant, properties: new Dictionary<string, object>() { { StaticRoleNames.Tenants.Customers, true } });
            flights.CreateChildPermission(AppPermissions.Pages_Flights_Create, L("CreateNewFlight"), multiTenancySides: MultiTenancySides.Tenant);
            flights.CreateChildPermission(AppPermissions.Pages_Flights_Edit, L("EditFlight"), multiTenancySides: MultiTenancySides.Tenant);
            flights.CreateChildPermission(AppPermissions.Pages_Flights_Delete, L("DeleteFlight"), multiTenancySides: MultiTenancySides.Tenant);
            flights.CreateChildPermission(AppPermissions.Pages_Flights_Book, L("BookFlight"), multiTenancySides: MultiTenancySides.Tenant, properties: new Dictionary<string, object>() { { StaticRoleNames.Tenants.Customers, true } });



            var cities = pages.CreateChildPermission(AppPermissions.Pages_Cities, L("Cities"), multiTenancySides: MultiTenancySides.Tenant);
            cities.CreateChildPermission(AppPermissions.Pages_Cities_Create, L("CreateNewCity"), multiTenancySides: MultiTenancySides.Tenant);
            cities.CreateChildPermission(AppPermissions.Pages_Cities_Edit, L("EditCity"), multiTenancySides: MultiTenancySides.Tenant);
            cities.CreateChildPermission(AppPermissions.Pages_Cities_Delete, L("DeleteCity"), multiTenancySides: MultiTenancySides.Tenant);

            var jets = pages.CreateChildPermission(AppPermissions.Pages_Jets, L("Jets"), multiTenancySides: MultiTenancySides.Tenant);
            jets.CreateChildPermission(AppPermissions.Pages_Jets_Create, L("CreateNewJet"), multiTenancySides: MultiTenancySides.Tenant);
            jets.CreateChildPermission(AppPermissions.Pages_Jets_Edit, L("EditJet"), multiTenancySides: MultiTenancySides.Tenant);
            jets.CreateChildPermission(AppPermissions.Pages_Jets_Delete, L("DeleteJet"), multiTenancySides: MultiTenancySides.Tenant);


            var users = pages.CreateChildPermission(AppPermissions.Pages_Users, L("Users"));
            var roles = pages.CreateChildPermission(AppPermissions.Pages_Roles, L("Roles"));
            var tenants = pages.CreateChildPermission(AppPermissions.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BookingSystemConsts.LocalizationSourceName);
        }
    }
}
