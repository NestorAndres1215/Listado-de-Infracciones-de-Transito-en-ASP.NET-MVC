using System;
using System.Collections.Generic;

#nullable disable

namespace EC3_NESTOR_ATIRO_MVCASPNET.Models
{
    public partial class Papeleta
    {
        public int Nropap { get; set; }
        public string Nropla { get; set; }
        public string Codinf { get; set; }
        public string Idpol { get; set; }
        public DateTime? Papfecha { get; set; }
        public string Pagado { get; set; }
        public DateTime? Fecpago { get; set; }
        public string Eliminado { get; set; }

        public virtual Infraccione CodinfNavigation { get; set; }
        public virtual Policia IdpolNavigation { get; set; }
        public virtual Vehiculo NroplaNavigation { get; set; }
    }
}
