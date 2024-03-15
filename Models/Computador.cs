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
        [Display(Name = "Placa-mãe")]
        public string PlacaMae { get; set; }
        [Display(Name = "Memória")]
        public string Memoria { get; set; }
        [Display(Name = "HD")]
        public string Hd { get; set; }
        [Required]
        [Display(Name = "Número do patrimônio")]
        public int NumeroPratrimonio { get; set; }
        [Required]
        [Display(Name = "Data de entrega")]
        public string DataDeEntrega { get; set; }
    }
}
