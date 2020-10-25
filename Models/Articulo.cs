using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Parcial.Models
{
    public class Articulo
    {
        [Key]
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public int ArticuloId {get; set;}
        
        [ForeignKey("ArticuloId")]
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public int DepartamentoId {get; set;}

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Referencia {get; set;}
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Descripcion {get;set;}
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public decimal Precio {get;set;}
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public int Existencia{get;set;}

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Departamento {get; set;}



        public Articulo(){
            ArticuloId = 0;
            DepartamentoId = 0;
            Referencia = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            Departamento = string.Empty;
        }
    }
}