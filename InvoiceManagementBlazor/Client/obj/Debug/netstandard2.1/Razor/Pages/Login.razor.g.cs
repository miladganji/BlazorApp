#pragma checksum "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088f873930a5f53f48a73d9ce5822452ca1d6275"
// <auto-generated/>
#pragma warning disable 1591
namespace InvoiceManagementBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using InvoiceManagementBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using InvoiceManagementBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using InvoiceManagementBlazor.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\_Imports.razor"
using InvoiceManagementBlazor.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"col-6\" style=\"border-right:3px;border-color:gray;float:left\">\r\n    <img src=\"download.jpg\" class=\"col-11\">\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-6");
            __builder.AddAttribute(3, "style", "float:right;padding-top:50px;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                         user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                                                LogintoSite

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<label class=\"font-weight-bold\" style=\"color:purple;\">Login to System</label>\r\n\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control col-7");
                __builder2.AddAttribute(21, "placeholder", "Username");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                                        user.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.UserName = __value, user.UserName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __Blazor.InvoiceManagementBlazor.Client.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 19 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                                          ()=>user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control col-7");
                __builder2.AddAttribute(35, "placeholder", "Password");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                                        user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __Blazor.InvoiceManagementBlazor.Client.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 26 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                                          ()=>user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n            ");
                __builder2.AddMarkupContent(44, "<button class=\"btn btn-info\">Login</button>\r\n            ");
                __builder2.AddMarkupContent(45, "<a class=\"btn btn-warning\" href=\"/SignUp\">sign up</a>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n\r\n");
#nullable restore
#line 33 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
         if (LoginFailed != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-12");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "span");
            __builder.AddAttribute(52, "class", "font-weight-bold");
            __builder.AddAttribute(53, "style", "color:red;");
            __builder.AddContent(54, 
#nullable restore
#line 36 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
                                                                   LoginFailed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 38 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\Login.razor"
       
    public class LoginData
    {
        public string username { get; set; }
        public string Password { get; set; }

    }

    public User user = new User();
    [Parameter] public string LoginFailed { get; set; } = null;

    public async Task LogintoSite()
    {
        Console.WriteLine(user.FullName);
        Console.WriteLine(user.UserName);
        Console.WriteLine(user.Password);
        Console.WriteLine(navigationManager.BaseUri);




        try
        {
            LoginData loginData = new LoginData() {
                username=user.UserName,
                Password=user.Password
            };
            var res = await httpservice.Post(navigationManager.BaseUri + "api/Home/CreateToken",  loginData);

            Console.WriteLine(await res.response.Content.ReadAsStringAsync());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            throw new ArgumentException(ex.Message);
        }


        navigationManager.NavigateTo("/");

        await Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IhttpService httpservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.InvoiceManagementBlazor.Client.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
