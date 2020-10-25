using System.ComponentModel.DataAnnotations;

namespace Prueba_Parcial.Models
{
    public class Departamento
    {
        [Key]
        [Required(ErrorMessage ="Este campo es obligario.")]
        public int DepartamentoId {get; set;}
        [Required(ErrorMessage ="Este campo es obligario.")]
        public string Descripcion {get; set;}

        public Departamento(){
            DepartamentoId = 0;
            Descripcion = string.Empty;
        }
    }
}