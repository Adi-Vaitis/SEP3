#pragma checksum "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/FirstPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0615780508c29adad94ba42c0f771b45d23f2724"
// <auto-generated/>
#pragma warning disable 1591
namespace Tier_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1.Data.BurialService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1.Data.ClientService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1.Data.PreferenceService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FirstPage : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"centered\"><h1><b>Highway to Heaven</b></h1></div>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12");
            __builder.AddAttribute(7, "id", "firstPageButtons");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/FirstPage.razor"
                                            NavigateToLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "firstPageButtons");
            __builder.AddContent(12, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/FirstPage.razor"
                                            NavigateToViewBurialsPreferences

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "firstPageButtons");
            __builder.AddContent(18, "Burials and Preferences");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/FirstPage.razor"
       
    private void NavigateToLogin()
    {
        NavigationManager.NavigateTo("/Login");
    }

    private void NavigateToViewBurialsPreferences()
    {
        NavigationManager.NavigateTo("/ViewBurialsPreferences");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBurialService BurialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
