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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MapacheBigoton
{
    public partial class FrmServicios : Form
    {
        private readonly ServicioRepository _servicioRepository;
        private readonly List<Color> colores = new List<Color>
        {
            Color.FromArgb(0x87, 0xCE, 0xEB), // #87CEEB
            Color.FromArgb(0x70, 0x80, 0x90), // #708090
            Color.FromArgb(0x6B, 0x8E, 0x23), // #6B8E23
            Color.FromArgb(0xFF, 0x63, 0x47), // #FF6347
            Color.FromArgb(0xFF, 0xA5, 0x00), // #FFA500
            Color.FromArgb(0x46, 0x82, 0xB4), // #4682B4
            Color.FromArgb(0xFF, 0x69, 0xB4), // #FF69B4
            Color.FromArgb(0x98, 0xFF, 0x98)  // #98FF98
        };
        Sucursal sucursal;

        private int colorIndex = 0; // Índice para rastrear el color actual

        public FrmServicios(Sucursal sucursal)
        {
            InitializeComponent();
            _servicioRepository = new ServicioRepository(new DatabaseConnection());
            this.sucursal = sucursal;
            CargarServicios();
        }

        public void CargarServicios()
        {
            List<Service> services = _servicioRepository.ObtenerServicios(sucursal.IdSucursal);
            flpServicios.Controls.Clear();

            foreach (Service service in services)
            {
                UserControlServicio userControlServicio = new UserControlServicio();
                userControlServicio.CargarDatosServicios(service);


                // Asignar el color en secuencia
                userControlServicio.BackColor = colores[colorIndex];
                userControlServicio.richDescripcionServicio.BackColor = colores[colorIndex];
                // Incrementar el índice y reiniciarlo si llega al final de la lista
                colorIndex = (colorIndex + 1) % colores.Count;

                userControlServicio.Dock = DockStyle.Top;
                flpServicios.Controls.Add(userControlServicio);
            }
        }

        private void panelCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            // Crear una instancia del formulario FrmCitas
            FrmCitas frmCitas = new FrmCitas(sucursal);
            frmCitas.Show();
            //this.Close();

        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            FrmAgregarServicio frmAgregarServicio = new FrmAgregarServicio(this, sucursal);
            frmAgregarServicio.ShowDialog();
        }


        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            FrmCitas frmCitas = new FrmCitas(sucursal);
            frmCitas.Show();
            //this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estas en servicios");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("Estas en servicios");
        }

        private void lClientes_Click(object sender, EventArgs e)
        {
            frmAgendar frmAgendar = new frmAgendar(sucursal);
            frmAgendar.Show();
            //this.Close();

        }
    }
}
