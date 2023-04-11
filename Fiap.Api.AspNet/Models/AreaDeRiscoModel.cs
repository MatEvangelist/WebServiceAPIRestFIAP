using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.AspNet.Models
{
    [Table("T_AREA_DE_RISCO")]
    public class AreaDeRiscoModel
    {
        [HiddenInput]
        [Key]
        [Column("id_area_de_risco")]
        public int AreaDeRiscoId { get; set; }

        [Column("localizacao_area_de_risco")]
        public string LocalizacaoAreaDeRisco { get; set; }

        [Column("nivel_rio_area_de_risco_cm")]
        public int NivelRioAreaDeRisco { get; set; }

        [Column("dt_ultimo_registro")]
        public DateTime DataUltimoRegistro { get; set; }

        //foreign key
        [Column("id_rio")]
        public int RioId { get; set; }

        //foreign key
        [Column("T_PLUVIOMETRO_id_pluviometro")]
        public int PluviometroId { get; set; }

        public RioModel? Rio { get; set; }
        public PluviometroModel? Pluviometro { get; set; }
    }
}
