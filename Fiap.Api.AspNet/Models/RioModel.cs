using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.AspNet.Models
{
    [Table("T_RIO")]
    public class RioModel
    {
        [Key]
        [Column("id_rio")]
        public int RioId { get; set; }

        [Column("nm_rio")]
        public string NomeRio { get; set; }

        [Column("ds_rio")]
        public string DescricaoRio { get; set; }

    }

}
