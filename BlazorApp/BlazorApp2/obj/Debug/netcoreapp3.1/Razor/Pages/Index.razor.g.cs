#pragma checksum "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20bbc6709994e34704f96b0be3149dc433279e5a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using BlazorApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/electriclamb/Desktop/RookiesUnityPart6/BlazorApp/BlazorApp2/_Imports.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<BlazorApp2.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591