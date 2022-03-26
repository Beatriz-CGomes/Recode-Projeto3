using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Consulta
    { 
        [Key]
        public int Id_Consulta { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Entrada { get; set; }   
        public DateTime Saida { get; set; }
    }
}
