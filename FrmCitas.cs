using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using MapacheBigoton.Controls;
using MapacheBigoton.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapacheBigoton
{
    public partial class FrmCitas : Form
    {
        private readonly CitaRepository _citaRepository;
        public FrmCitas()
        {
            InitializeComponent();
            _citaRepository = new CitaRepository(new DatabaseConnection());
            CargarCitas();
        }

        private void CargarCitas()
        {
            List<Cita> citas = _citaRepository.ObtenerCitas();

            // Limpia el panel antes de agregar los controles
            flowLayoutPanel1.Controls.Clear();

            foreach (var cita in citas)
            {
                UserControlCitaAgendada userControl = new UserControlCitaAgendada();
                userControl.CargarDatos(cita);
                userControl.Dock = DockStyle.Top; // Asegúrate de que los controles se apilen verticalmente
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

    }
}
