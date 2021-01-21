using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputoVotosREST_API.Models
{
    [Table("cv_tipo_eleccion", Schema = "dbo")]
    public partial class TipoEleccion
    {
        [Key()]
        public int IdTipoEle { get; set; }
        public string Cargo { get; set; }
    }
}
