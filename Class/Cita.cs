using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapacheBigoton.Class
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdSucursal { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int idClient { get; set; }
        public int idBarber { get; set; }
        public int idService { get; set; }
    }

}
