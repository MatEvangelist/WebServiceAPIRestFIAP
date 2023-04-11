using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.AspNet.Models
{
    [Table("T_PLUVIOMETRO")]
    public class PluviometroModel
    {
        [Key]
        [Column("id_pluviometro")]
        public int PluviometroId { get; set; }

        [Column("nivel_chuva")]
        public int NivelChuva { get; set; }

        [Column("ds_pluviometro")]
        public string DescricaoPluviometro { get; set; }

        [Column("dt_ultimo_registro")]
        public DateTime DataUltimoRegistro { get; set; }
    }
}
