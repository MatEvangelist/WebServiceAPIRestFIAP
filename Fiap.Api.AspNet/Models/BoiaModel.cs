using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.AspNet.Models
{
    [Table("T_BOIA_MONITO")]
    public class BoiaModel
    {
        [Key]
        [Column("id_ferramenta")]
        public int FerramentaId { get; set; }

        [Column("localizacao_ferramenta")]
        public int LocalizacaoFerramenta { get; set; }

        [Column("status_rio")]
        public string StatusRio { get; set; }

        [Column("alerta_risco")]
        public bool AlertaRisco { get; set; }

        [Column("dt_ultimo_registro")]
        public DateTime DataUltimoRegistro { get; set; }

        [Column("id_rio")]
        public int RioId { get; set; }

        public RioModel? Rio { get; set; }
    }
}
