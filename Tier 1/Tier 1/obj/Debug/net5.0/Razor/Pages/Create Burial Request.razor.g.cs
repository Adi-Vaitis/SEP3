#pragma checksum "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/Create Burial Request.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c531cafdf0d26ee41413712283b8bf2014e29ba"
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
#nullable restore
#line 2 "/Users/admin/Documents/GitHub/SEP3/Tier 1/Tier 1/Pages/Create Burial Request.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Create_Burial_Request")]
    public partial class Create_Burial_Request : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Burial Request</h3>\n");
            __builder.AddMarkupContent(1, "<h4>Type of Burial</h4>\n\n");
            __builder.AddMarkupContent(2, "<div class=\"col-md-6 control-section\"><h5>Please select an option:</h5></div>\n\n}");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBurialService BurialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
