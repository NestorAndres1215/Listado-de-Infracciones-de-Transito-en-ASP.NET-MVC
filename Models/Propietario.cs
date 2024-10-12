using System;
using System.Collections.Generic;

#nullable disable

namespace EC3_NESTOR_ATIRO_MVCASPNET.Models
{
    public partial class Propietario
    {
        public Propietario()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public string Dnipro { get; set; }
        public string Nompro { get; set; }
        public string Dirpro { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
