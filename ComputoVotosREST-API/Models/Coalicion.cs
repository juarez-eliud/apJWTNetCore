using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputoVotosREST_API.Models
{
    public class Coalicion
    {
        [Key]
        public int CandID { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }


    }
}
