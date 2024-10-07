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

        public void CargarDatos(Cita cita,Client cliente, Barber barbero, Service Servicio)
        {
            lblFecha.Text = cita.Fecha.ToString("dd/MM/yyyy");
            lblCliente.Text = cliente.NombreCliente;
            lblBarbero.Text = barbero.NombreBarbero;
            lblServicio.Text = Servicio.NombreServicio;
        }
    }
}
