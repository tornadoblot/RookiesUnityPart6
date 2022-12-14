#pragma checksum "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08ca0b3560bac174d299986d5d3295a94dbfb1e6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStudy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using BlazorStudy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/_Imports.razor"
using BlazorStudy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
using BlazorStudy.Data;

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
#line 10 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
 if (_forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 13 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 26 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
             foreach (var forecast in _forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 29 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
__builder.AddContent(15, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 30 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
__builder.AddContent(18, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 31 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
__builder.AddContent(21, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 32 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
__builder.AddContent(24, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 34 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.AddContent(30, "    ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
                                              AddNewForecast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\n        Add New Forecast\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 42 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"

    if(_showPopup)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal");
            __builder.AddAttribute(39, "style", "display: block");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.AddMarkupContent(41, "\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal-dialog");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-content");
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-header");
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.AddMarkupContent(51, "<h3 class=\"modal-title\">Add Forecast</h3>\n                        ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "close");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
                                                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "\n                            ");
            __builder.AddMarkupContent(57, "<span area-hidden=\"true\">X</span>\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-body");
            __builder.AddMarkupContent(62, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(63);
            __builder.AddAttribute(64, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
                                         _addForecast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 56 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
                                                                      SaveForecast

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(67, "\n\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(68);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(70);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\n\n                            ");
                __builder2.AddMarkupContent(72, "<label for=\"TemperatureC\">TemperatureC</label>\n                            ");
                __Blazor.BlazorStudy.Pages.FetchData.TypeInference.CreateInputNumber_0(__builder2, 73, 74, "form-control", 75, "TeperatureC", 76, 
#nullable restore
#line 65 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
                                                                                                     _addForecast.TemperatureC

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _addForecast.TemperatureC = __value, _addForecast.TemperatureC)), 78, () => _addForecast.TemperatureC);
                __builder2.AddMarkupContent(79, "\n                            ");
                __builder2.AddMarkupContent(80, "<label for=\"Summary\">Summary</label>\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "placeholder", "Summary");
                __builder2.AddAttribute(84, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
                                                                                               _addForecast.Summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _addForecast.Summary = __value, _addForecast.Summary))));
                __builder2.AddAttribute(86, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _addForecast.Summary));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n                            <br>\n\n                            ");
                __builder2.AddMarkupContent(88, "<button class=\"btn btn-primary\" type=\"submit\">Save</button>\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n");
#nullable restore
#line 76 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/FetchData.razor"
       
    private List<WeatherForecast> _forecasts;

    bool _showPopup = false;
    WeatherForecast _addForecast;

    protected override async Task OnInitializedAsync()
    {
        _forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

    public void AddNewForecast()
    {
        _showPopup = true;
        _addForecast = new WeatherForecast();
    }

    void SaveForecast()
    {
        _showPopup = false;
        _addForecast.Date = DateTime.Now;
        _forecasts.Add(_addForecast);
    }

    void ClosePopup()
    {
        _showPopup = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.BlazorStudy.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
