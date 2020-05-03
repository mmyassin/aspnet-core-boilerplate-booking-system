using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using BookingSystem.Authorization;

namespace BookingSystem.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class AppNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        AppPageNames.Common.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fas fa-home",
                        requiresAuthentication: true,
                        order: 1
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        AppPageNames.Common.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "fas fa-building",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        AppPageNames.Common.Users,
                        L("Users"),
                        url: "Users",
                        icon: "fas fa-users",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Users),
                        order: 3
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        AppPageNames.Common.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "fas fa-theater-masks",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Roles),
                        order: 2
                            )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Tenant.Cities,
                        L("Cities"),
                        url: "Cities",
                        icon: "fas fa-map-marker-alt",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Cities),
                        order: 4
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Tenant.Jets,
                        L("Jets"),
                        url: "Jets",
                        icon: "fas fa-plane",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Jets),
                        order: 5
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Tenant.Flights,
                        L("Flights"),
                        url: "Flights/Index",
                        icon: "fas fa-plane-departure",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Flights),
                        order: 6
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Tenant.MyTickets,
                        L("MyTickets"),
                        url: "Flights/MyTickets",
                        icon: "fa fa-ticket-alt",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Flights),
                        order: 7
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BookingSystemConsts.LocalizationSourceName);
        }
    }
}
