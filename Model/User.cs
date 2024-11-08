using System.ComponentModel.DataAnnotations;

namespace Autentificacion.Model
{
    public class User
    {

        [Required] // Verificar que se importo using System.ComponentModet.DataAnotations
        [DataType(DataType.EmailAddress)]
        public string Email {  get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
