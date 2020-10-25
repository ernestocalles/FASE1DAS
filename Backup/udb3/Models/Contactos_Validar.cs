using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace udb3.Models
{
    public class Contactos_Validar
    {
        [Required(ErrorMessage = "Este dato es requerido.")]
		public string Nombre { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Debe ser una direccion de correo valida.")]
		public string Correo { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
		public string Asunto { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
		public int TipoContacto { get; set; }
    }
}