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
    public partial class FrmBarbero : Form

    {
        private readonly BarberoRepository _barberoRepository;

        public FrmBarbero()
        {
            InitializeComponent();
            _barberoRepository = new BarberoRepository(new DatabaseConnection());
            CargarBarberos();
        }
        private void CargarBarberos()
        {
            List<Barber> barberos = _barberoRepository.ObtenerBarberos();

            // Limpia el panel antes de agregar los controles
            flowLayoutPanel1.Controls.Clear();

            foreach (var barbero in barberos)
            {
                UserControlBarber userControl = new UserControlBarber();
                userControl.CargarDatos(barbero);
                userControl.Dock = DockStyle.Top; // Asegúrate de que los controles se apilen verticalmente
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBarbero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmServicios servicios = new FrmServicios();
            servicios.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Crear un nuevo barbero
            Barber nuevoBarbero = new Barber
            {
                NombreBarbero = txtNombreB.Text
            };

            // Agregar el nuevo barbero a la base de datos
            _barberoRepository.AgregarBarbero(nuevoBarbero);

            // Recargar la lista de barberos
            CargarBarberos();
        
    }
    }
}