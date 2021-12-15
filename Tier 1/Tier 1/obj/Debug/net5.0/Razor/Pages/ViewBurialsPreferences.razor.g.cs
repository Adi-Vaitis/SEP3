#pragma checksum "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7029d1a1e5243103ce4f290ee6f9afd4c06db0c"
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
#line 13 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/_Imports.razor"
using Tier_1.Data.ClientService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
using Tier_1.Data.BurialService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
using Tier_1.Data.PreferenceService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
using Tier_1.Models.Burial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
using Tier_1.Models.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
using Tier_1.Models.Preference;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
using Tier_1.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewBurialsPreferences")]
    public partial class ViewBurialsPreferences : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
 if (_burials == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading ...</em></p>");
#nullable restore
#line 19 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
}
else if (!_burials.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>No burials in the list.</em></p>");
#nullable restore
#line 25 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table styledTable");
            __builder.AddMarkupContent(10, "<thead><tr><th>Burial</th>\n                        <th>Preference Description</th></tr></thead>\n                    ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 39 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
                     foreach (var item in _preferencesToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 42 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
                                 item.BurialId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 43 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
                                 item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "}\n\n\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/ViewBurialsPreferences.razor"
       
    private Client client;
    private IList<Preference> _preferences;
    private IList<Preference> _preferencesToShow;
    private IList<Burial> _burials = new List<Burial>();

    protected override async Task OnInitializedAsync()
    {
        client = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).CachedUser;
        _preferences = new List<Preference>();
        _preferencesToShow = new List<Preference>();

        Client employeeAccount = new Client();
        employeeAccount = await ClientService.GetClientByUsername("ADMIN");
        _burials = await BurialService.GetBurialsAsync(employeeAccount.Id);
        _preferences = await PreferencesService.GetPreferencesAsync();

        _preferencesToShow = _preferences;
    }
    
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            client = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).CachedUser;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferencesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBurialService BurialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
