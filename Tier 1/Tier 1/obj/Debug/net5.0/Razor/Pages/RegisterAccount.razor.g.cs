#pragma checksum "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c9bd3a92e3f87745e4808a6beb51bba303b7c4"
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
#line 1 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Tier_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Tier_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Tier_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Tier_1.Data.BurialService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Tier_1.Data.ClientService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\_Imports.razor"
using Tier_1.Data.PreferenceService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
using Tier_1.Models.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class RegisterAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n.sidebar\r\n{\r\ndisplay: none !important;\r\n}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "loginForm");
            __builder.AddMarkupContent(3, "<h3>Create account ...</h3>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "Name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
                                                       _name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _name = __value, _name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    <br>\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "placeholder", "Username");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
                                                           _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    <br>\r\n    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "password");
            __builder.AddAttribute(18, "placeholder", "Password");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
                                                               _password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "color:red");
            __builder.AddContent(24, 
#nullable restore
#line 20 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
                            _errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <br>\r\n    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
                                    CreateAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "loginButtons");
            __builder.AddContent(30, "Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    <br>\r\n    ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
                         GoToLogIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "Having an account already? Come here!\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\RegisterAccount.razor"
       
    private string _username;
    private string _name;
    private string _password;
    private string _errorMessage;

    private async Task CreateAccount()
    {
        _errorMessage = "";
        try
        {
            if (!_name.Any() || !_username.Any() || !_password.Any())
            {
                return;
            }
            Client newClient = new Client(_username, _name, _password);
            String result = await ClientService.CreateClientAccount(newClient);
            if (result.Equals("\"Account already exists\""))
            {
                _errorMessage = result;
                _username = "";
                _name = "";
                _password = "";
                return;
            }
            _username = "";
            _name = "";
            _password = "";
            NavigationManager.NavigateTo("/login");
        }
        catch (Exception e)
        {
            _errorMessage = "All fields are required.";
        }
    }

    private void GoToLogIn()
    {
        NavigationManager.NavigateTo("/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService clientService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBurialService BurialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
