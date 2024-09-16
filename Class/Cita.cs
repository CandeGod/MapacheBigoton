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
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public Client Client { get; set; }
        public Barber Barber { get; set; }
        public Service Service { get; set; }
    }

}
