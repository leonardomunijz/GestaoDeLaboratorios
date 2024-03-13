using System.ComponentModel.DataAnnotations;
using System.Security;

namespace GestaoDeLaboratorios.Models
{
    public class Computador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Processador { get; set; }
        public string PlacaMae { get; set; }
        public string Memoria { get; set; }
        public string Hd { get; set; }
        [Required]
        public int NumeroPratrimonio { get; set; }
        [Required]
        public string DataDeEntrega { get; set; }
    }
}
