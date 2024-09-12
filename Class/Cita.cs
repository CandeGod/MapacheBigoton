using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapacheBigoton.Class
{
    public class Cita
    {
        int IdCita { get; set; }
        DateTime Fecha { get; set; }
        Client Client { get; set; }
        Barber Barber { get; set; }
        Service Service { get; set; }
    }

}
