<<<<<<< HEAD
#pragma checksum "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d510bbdc53973b6f21236c71adaf0dad1c1977d9"
=======
#pragma checksum "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d510bbdc53973b6f21236c71adaf0dad1c1977d9"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
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
<<<<<<< HEAD
#line 1 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 1 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 2 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 3 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 4 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 5 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 6 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 7 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 8 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using InvoiceManagementBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 9 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using InvoiceManagementBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 10 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 10 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using InvoiceManagementBlazor.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 11 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
=======
#line 11 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using InvoiceManagementBlazor.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 12 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\BlazorApp\InvoiceManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
using InvoiceManagementBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 9 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 9 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 12 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 12 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
<<<<<<< HEAD
#line 25 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 25 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
<<<<<<< HEAD
#line 28 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 28 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
<<<<<<< HEAD
#line 29 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 29 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
<<<<<<< HEAD
#line 30 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 30 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
<<<<<<< HEAD
#line 31 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 31 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
<<<<<<< HEAD
#line 33 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 33 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
<<<<<<< HEAD
#line 36 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 36 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 38 "E:\blazorApp\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
=======
#line 38 "D:\BlazorApp\InvoiceManagementBlazor\Client\Pages\FetchData.razor"
>>>>>>> 8f5c83a90ca4f08f7c35721978d89a3956f1c76c
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
