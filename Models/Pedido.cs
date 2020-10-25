using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Prueba_Parcial.Models
{
    public class Pedido
    {
        [Key]
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public int PedidoId {get;set;}

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public DateTime Fecha {get;set;}

        [ForeignKey("PedidoId")]
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public int ArticuloId{get;set;}

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public decimal Precio {get;set;}

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public int Cantidad {get;set;}

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public decimal Total {get;set;}

        public Pedido(){
            
            PedidoId = 0;
            Fecha = DateTime.Now;
            ArticuloId = 0;
            Precio = 0;
            Cantidad = 0;
            Total = 0;

        }
    }
}