using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Fiap.Api.AspNet.Models
{
    public class RioModel
    {
        [Key]
        public int RioId { get; set; }
        public string NomeRio { get; set; }
        public string DescricaoRio { get; set; }

    }

}
