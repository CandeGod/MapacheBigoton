using MapacheBigoton.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapacheBigoton.Controls
{
    public partial class UserControlCitaAgendada : UserControl
    {
        public UserControlCitaAgendada()
        {
            InitializeComponent();
        }

        public void CargarDatos(Cita cita)
        {
            lblFecha.Text = cita.Fecha.ToString("dd/MM/yyyy");
            lblCliente.Text = cita.Client.NombreCliente;
            lblBarbero.Text = cita.Barber.NombreBarbero;
            lblServicio.Text = cita.Service.NombreServicio;
        }
    }
}
