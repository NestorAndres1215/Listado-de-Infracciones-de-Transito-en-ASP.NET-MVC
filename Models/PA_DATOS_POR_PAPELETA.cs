using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EC3_NESTOR_ATIRO_MVCASPNET.Models
{
    public class PA_DATOS_POR_PAPELETA
    {
        [Key]
        public string Codinf { get; set; }
        public string Desinf { get; set; }
        public string idpol { get; set; }
        public string nompol { get; set; }
        public decimal importe { get; set; }
    }
}
