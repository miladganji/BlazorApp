#pragma checksum "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f11f827a1b3af87940e2354d3836df89eabe013"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\m.ganjinejad\source\repos\InvoiceManagementBlazor\InvoiceManagementBlazor\Client\Pages\SignUp.razor"
       
    public User user = new User();
    [Parameter] public string LoginFailed { get; set; } = null;

    public void LogintoSite()
    {
        navigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591