#pragma checksum "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50b925c960382afbcb46817cf9b4af1435f2053"
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
#line 2 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
using Tier_1.Models.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
using Tier_1.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoginPage")]
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<style>html {\r\n         height: 100%;\r\n       }\r\n       body {\r\n         margin:0;\r\n         padding:0;\r\n         font-family: sans-serif;\r\n         background: linear-gradient(#141e30, #243b55);\r\n       }\r\n       \r\n       .login-box {\r\n         position: absolute;\r\n         top: 50%;\r\n         left: 50%;\r\n         width: 400px;\r\n         padding: 40px;\r\n         transform: translate(-50%, -50%);\r\n         background: rgba(0,0,0,.5);\r\n         box-sizing: border-box;\r\n         box-shadow: 0 15px 25px rgba(0,0,0,.6);\r\n         border-radius: 10px;\r\n       }\r\n       \r\n       .login-box h2 {\r\n         margin: 0 0 30px;\r\n         padding: 0;\r\n         color: #fff;\r\n         text-align: center;\r\n       }\r\n       \r\n       .login-box .user-box {\r\n         position: relative;\r\n       }\r\n       \r\n       .login-box .user-box input {\r\n         width: 100%;\r\n         padding: 10px 0;\r\n         font-size: 16px;\r\n         color: #fff;\r\n         margin-bottom: 30px;\r\n         border: none;\r\n         border-bottom: 1px solid #fff;\r\n         outline: none;\r\n         background: transparent;\r\n       }\r\n       .login-box .user-box label {\r\n         position: absolute;\r\n         top:0;\r\n         left: 0;\r\n         padding: 10px 0;\r\n         font-size: 16px;\r\n         color: #fff;\r\n         pointer-events: none;\r\n         transition: .5s;\r\n       }\r\n       \r\n       .login-box .user-box input:focus ~ label,\r\n       .login-box .user-box input:valid ~ label {\r\n         top: -20px;\r\n         left: 0;\r\n         color: #03e9f4;\r\n         font-size: 12px;\r\n       }\r\n       \r\n       .login-box form a {\r\n         position: relative;\r\n         display: inline-block;\r\n         padding: 10px 20px;\r\n         color: #03e9f4;\r\n         font-size: 16px;\r\n         text-decoration: none;\r\n         text-transform: uppercase;\r\n         overflow: hidden;\r\n         transition: .5s;\r\n         margin-top: 40px;\r\n         letter-spacing: 4px\r\n       }\r\n       \r\n       .login-box a:hover {\r\n         background: #03e9f4;\r\n         color: #fff;\r\n         border-radius: 5px;\r\n         box-shadow: 0 0 5px #03e9f4,\r\n                     0 0 25px #03e9f4,\r\n                     0 0 50px #03e9f4,\r\n                     0 0 100px #03e9f4;\r\n       }\r\n       \r\n       .login-box a span {\r\n         position: absolute;\r\n         display: block;\r\n       }\r\n       \r\n       .login-box a span:nth-child(1) {\r\n         top: 0;\r\n         left: -100%;\r\n         width: 100%;\r\n         height: 2px;\r\n         background: linear-gradient(90deg, transparent, #03e9f4);\r\n         animation: btn-anim1 1s linear infinite;\r\n       }\r\n       \r\n       \r\n       \r\n       .login-box a span:nth-child(2) {\r\n         top: -100%;\r\n         right: 0;\r\n         width: 2px;\r\n         height: 100%;\r\n         background: linear-gradient(180deg, transparent, #03e9f4);\r\n         animation: btn-anim2 1s linear infinite;\r\n         animation-delay: .25s\r\n       }\r\n       \r\n       \r\n       \r\n       .login-box a span:nth-child(3) {\r\n         bottom: 0;\r\n         right: -100%;\r\n         width: 100%;\r\n         height: 2px;\r\n         background: linear-gradient(270deg, transparent, #03e9f4);\r\n         animation: btn-anim3 1s linear infinite;\r\n         animation-delay: .5s\r\n       }\r\n       \r\n       \r\n       \r\n       .login-box a span:nth-child(4) {\r\n         bottom: -100%;\r\n         left: 0;\r\n         width: 2px;\r\n         height: 100%;\r\n         background: linear-gradient(360deg, transparent, #03e9f4);\r\n         animation: btn-anim4 1s linear infinite;\r\n         animation-delay: .75s\r\n       }\r\n       \r\n     \r\n       \r\n</style>\r\n    ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "login-box");
                __builder2.AddMarkupContent(5, "<h2>Login</h2>\r\n      ");
                __builder2.OpenElement(6, "form");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "user-box");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 156 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
                                          _username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n          ");
                __builder2.AddMarkupContent(14, "<label>Username</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "user-box");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "password");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 160 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
                                              _password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n          ");
                __builder2.AddMarkupContent(23, "<label>Password</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "style", "color:red");
                __builder2.AddContent(27, 
#nullable restore
#line 163 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
                                 _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 164 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
                     Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(31, "<span></span>\r\n          <span></span>\r\n          <span></span>\r\n          <span></span>\r\n          Login\r\n        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\vaiti\Documents\GitHub\SEP3\Tier 1\Tier 1\Pages\LoginPage.razor"
       
  private string _username;
  private string _password;
  private string _errorMessage;
  private Client client;
  
  private async Task Login()
  {
    _errorMessage = "";
    try
    {
      Client user = await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(new Client(_username, _password));
      _username = "";
      _password = "";
    //  NavigationManager.NavigateTo("Index");
    }
    catch (Exception e)
    {
      _errorMessage = e.Message;
    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPreferenceService PreferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBurialService BurialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
