#pragma checksum "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "569275c360bc1fcc24fc72cc78485b2a4b4074d2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Prueba_Parcial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Prueba_Parcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Prueba_Parcial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/miguelgondres/Projects/Prueba_Parcial/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/FetchData.razor"
using Prueba_Parcial.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591