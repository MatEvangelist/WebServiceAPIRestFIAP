using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Fiap.Api.AspNet.Models
{
    public class BoiaModel
    {
        [Key]
        public int FerramentaId { get; set; }

        public int LocalizacaoFerramenta { get; set; }

        public string? StatusRio { get; set; }

        public bool AlertaRisco { get; set; }

        public string DataUltimoRegistro { get; set; }

        [ForeignKey("RioModel")]
        public int RioId { get; set; }

        //public virtual RioModel RioModel { get; set; }
    }
}
