// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/CreateBurial.razor"
using Tier_1.Data.PreferenceService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/CreateBurial.razor"
using Tier_1.Data.BurialService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateBurial")]
    public partial class CreateBurial : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBurialService BurialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
