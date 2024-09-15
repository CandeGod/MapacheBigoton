using MapacheBigoton.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapacheBigoton.Controls
{
    public partial class UserControlServicio : UserControl
    {
        public UserControlServicio()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(UserControlServicio_Paint);
        }

        public void CargarDatosServicios(Service service)
        {
            lblServicio.Text = service.NombreServicio;
            lblPrecio.Text = service.CostoServicio.ToString();
            richDescripcionServicio.Text = service.DescripcionServicio;
        }

        private void UserControlServicio_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 1; // Ancho del borde
            int radius = 10; // Radio de las esquinas redondeadas

            // Crea un GraphicsPath para las esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Esquina superior izquierda
            path.AddArc(Width - radius - borderWidth, 0, radius, radius, 270, 90); // Esquina superior derecha
            path.AddArc(Width - radius - borderWidth, Height - radius - borderWidth, radius, radius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, Height - radius - borderWidth, radius, radius, 90, 90); // Esquina inferior izquierda
            path.CloseAllFigures();

            // Define la región del control con esquinas redondeadas
            this.Region = new Region(path);

            // Dibuja el borde del control
            using (Pen pen = new Pen(Color.Black, borderWidth)) // Color del borde y ancho
            {
                e.Graphics.DrawPath(pen, path);
            }

        }
    }
}
