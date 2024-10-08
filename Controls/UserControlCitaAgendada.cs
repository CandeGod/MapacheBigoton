using MapacheBigoton.Class;
using System;
using System.Windows.Forms;

namespace MapacheBigoton.Controls
{
    public partial class UserControlCitaAgendada : UserControl
    {
        public UserControlCitaAgendada()
        {
            InitializeComponent();
        }

        // Método para cargar los datos de la cita
        public void CargarDatos(Cita cita)
        {
            lblFecha.Text = cita.Fecha.ToString("dd/MM/yyyy");
            lblCliente.Text = "Cliente: " + cita.Client.NombreCliente;
            lblBarbero.Text = "Barbero: " + cita.Barber.NombreBarbero;
            lblServicio.Text = "Servicio: " + cita.Service.NombreServicio;
        }
    }
}
