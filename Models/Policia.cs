using System;
using System.Collections.Generic;

#nullable disable

namespace EC3_NESTOR_ATIRO_MVCASPNET.Models
{
    public partial class Policia
    {
        public Policia()
        {
            Papeleta = new HashSet<Papeleta>();
        }

        public string Idpol { get; set; }
        public string Nompol { get; set; }
        public string Nropat { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Papeleta> Papeleta { get; set; }
    }
}
