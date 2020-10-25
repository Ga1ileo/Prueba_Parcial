#pragma checksum "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/ConsultaArticulo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "927e92751f95007d1553376148cbeaf1553537be"
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
#line 3 "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/ConsultaArticulo.razor"
using Prueba_Parcial.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/ConsultaArticulo.razor"
using Prueba_Parcial.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/ConsultaArticulo.razor"
using Prueba_Parcial.DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ConsultaArticulo")]
    public partial class ConsultaArticulo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "/Users/miguelgondres/Projects/Prueba_Parcial/Pages/ConsultaArticulo.razor"
       
    Articulo articulo = new Articulo();
    public int filtro { get; set; }   //departamento
    public string criterio { get; set; } //departamento
    
    public int filtroDescripcion { get; set; }   //Descripcion
    public string criterioDescripcion { get; set; } //Descripcion
    
    public decimal cantidad { get; set; }
    
    public List<Articulo> lista = new List<Articulo>();
    
    //Pedidos
    Pedido pedido = new Pedido();
    [Parameter]
    public int PedidoId { get; set; }
    private List<Pedido> listaPedido = new List<Pedido>();


    protected override void OnInitialized()
    {
        Nuevo();
    }

    private void Nuevo()
    {
        this.pedido = new Pedido();
    }

    //Metodo que pide un Articulo
    private void Pedir()
    {
        bool paso;
        paso = PedidoBLL.Guardar(pedido);

        if (paso)
        {
            Nuevo();
            NumeroDePedido();
            Console.WriteLine("Guardado Correctamente");
        }
        else
        {
            Console.WriteLine("No fue posible guardar");
        }
    }


    private void ConsultarDepartamentos()
    {
        try
        {
            switch (filtro)
            {
                case 0: //Departamentos
                    this.lista = ArticuloBLL.GetList(p => p.DepartamentoId == 1);
                    break;
                case 1: //Todos
                    this.lista = ArticuloBLL.GetList(p => p.DepartamentoId == 2);
                break;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void ConsultarDescripcion()
    {
        try
        {
            switch (filtroDescripcion)
            {
                case 0: //Descripcion
                    this.lista = ArticuloBLL.GetList(p => p.Descripcion == criterioDescripcion);
                    break;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    
    private int NumeroPedido = 0;

    private void NumeroDePedido()
    {
        NumeroPedido++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
