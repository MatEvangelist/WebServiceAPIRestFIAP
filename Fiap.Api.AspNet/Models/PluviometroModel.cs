using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Fiap.Api.AspNet.Models
{
    public class PluviometroModel
    {
        [Key]
        public int PluviometroId { get; set; }
        public int NivelChuva { get; set; }
        public string DescricaoPluviometro { get; set; }
        public string DataUltimoRegistro { get; set; }
    }
}
