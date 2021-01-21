using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputoVotosREST_API.Models
{

    [Table("cv_tipo_constitucion", Schema = "dbo")]
    public partial class TipoConstitucion
    {
        [Key()]
        public int IdTipoConst { get; set; }
        public string Nombre { get; set; }
    }
}
