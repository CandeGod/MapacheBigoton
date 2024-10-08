using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using MapacheBigoton.Controls;
using MapacheBigoton.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapacheBigoton
{
    public partial class FrmCitas : Form
    {
        private readonly CitaRepository _citaRepository; // Repositorio para gestionar las citas
        private readonly Sucursal _sucursalSeleccionada; // Sucursal seleccionada para mostrar citas

        public FrmCitas(Sucursal sucursalSeleccionada)
        {
            InitializeComponent();
            _citaRepository = new CitaRepository(new DatabaseConnection()); // Inicializa el repositorio con la conexión
            _sucursalSeleccionada = sucursalSeleccionada; // Asigna la sucursal seleccionada
            CargarCitas(); // Carga las citas al abrir el formulario
        }

        private void CargarCitas()
        {
            // Limpiar controles anteriores
            flowLayoutPanel1.Controls.Clear();

            // Obtener las citas de la sucursal seleccionada
            List<Cita> citas = _citaRepository.ObtenerCitasPorSucursal(_sucursalSeleccionada.IdSucursal);

            foreach (Cita cita in citas)
            {
                // Crear un control de usuario para cada cita y agregarlo al FlowLayoutPanel
                UserControlCitaAgendada controlCita = new UserControlCitaAgendada();
                controlCita.CargarDatos(cita); // Cargar datos de la cita
                flowLayoutPanel1.Controls.Add(controlCita); // Agregar el control al panel
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de agendar citas pasando la sucursal seleccionada
            frmAgendar frmAgendar = new frmAgendar(_sucursalSeleccionada);
            if (frmAgendar.ShowDialog() == DialogResult.OK)
            {
                // Si se agendó una cita correctamente, recargar las citas
                CargarCitas();
            }
        }

        // Método para manejar el evento de cierre del formulario, si es necesario
        private void FrmCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aquí puedes realizar cualquier acción necesaria al cerrar el formulario
            // Por ejemplo, confirmar si realmente desea cerrar
            // e.Cancel = MessageBox.Show("¿Estás seguro que deseas cerrar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No;
        }
    }
}
