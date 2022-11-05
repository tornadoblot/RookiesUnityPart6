#pragma checksum "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65974a7166a9c93d09ce31ecc4ef728191eeb445"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\n\n");
#nullable restore
#line 10 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 13 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<BlazorApp.Pages.TableTemplate<WeatherForecast>>(5);
            __builder.AddAttribute(6, "Items", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyList<WeatherForecast>>(
#nullable restore
#line 16 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
                          forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n            ");
                __builder2.AddMarkupContent(9, "<th>Date</th>\n            ");
                __builder2.AddMarkupContent(10, "<th>Temp. (C)</th>\n            ");
                __builder2.AddMarkupContent(11, "<th>Temp. (F)</th>\n            ");
                __builder2.AddMarkupContent(12, "<th>Summary</th>\n        ");
            }
            ));
            __builder.AddAttribute(13, "Row", (Microsoft.AspNetCore.Components.RenderFragment<WeatherForecast>)((forecast) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenElement(15, "td");
#nullable restore
#line 24 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
__builder2.AddContent(16, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n            ");
                __builder2.OpenElement(18, "td");
#nullable restore
#line 25 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
__builder2.AddContent(19, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.OpenElement(21, "td");
#nullable restore
#line 26 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
__builder2.AddContent(22, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.OpenElement(24, "td");
#nullable restore
#line 27 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
__builder2.AddContent(25, forecast.Summary);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 30 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
