using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.AspNet.Models
{
    public class AreaDeRiscoModel
    {
        [Key]
        public int AreaDeRiscoId { get; set; }

        public string LocalizacaoAreaDeRisco { get; set; }

        public int NivelRioAreaDeRisco { get; set; }

        public DateTime DataUltimoRegistro { get; set; }

        [ForeignKey("RioModel")]
        public int RioId { get; set; }

        [ForeignKey("PluviometroModel")]
        public int PluviometroId { get; set; }

        //public virtual RioModel RioModel { get; set; }

        //public virtual PluviometroModel PluviometroModel { get; set; }


    }
}
