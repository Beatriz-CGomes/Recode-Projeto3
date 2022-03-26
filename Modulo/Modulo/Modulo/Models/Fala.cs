using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Fala
    {  [Key]
         public int Id_fala { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }

    }
}
