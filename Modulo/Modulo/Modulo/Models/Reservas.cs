using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Reservas
    {  [Key]
        public int Id_Reserva { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
    }
}
