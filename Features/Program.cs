using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Features;
using Features.Northwind;
using Features.Financial;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IFinancialService>(sp => new FinancialService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbInputModule),
        typeof(IgbComboModule),
        typeof(IgbButtonModule),
        typeof(IgbStepperModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbPivotDataSelector),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbSnackbarModule)
    );
}