// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp/Pages/Counter.razor"
       
    [CascadingParameter(Name = "ThemeColor")]
    string _color { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    void AutoIncrement()
    {
        var timer = new Timer(x =>
        {
            InvokeAsync(() =>
            {
                IncrementCount();
                StateHasChanged();
            });
        }, null, 1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591