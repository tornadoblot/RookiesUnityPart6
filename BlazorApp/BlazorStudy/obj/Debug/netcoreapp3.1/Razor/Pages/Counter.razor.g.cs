#pragma checksum "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3270ca0f72b9042e64ee42fc6a46794b86392c44"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter/{CurrentCount:int}")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 7 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/Counter.razor"
__builder.AddContent(3, CurrentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n<a class=\"btn btn-primary\" href=\"FetchData\"></a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/Counter.razor"
       

    private void IncrementCount()
    {
        CurrentCount++;

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorStudy/Pages/Counter.razor"
                                               
    }

    [Parameter]
    public int CurrentCount { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591