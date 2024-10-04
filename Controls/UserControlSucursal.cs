using MapacheBigoton.Class;
using MapacheBigoton.Repository;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MapacheBigoton.Controls
{
    public partial class UserControlSucursal : UserControl
    {
        private Color originalBackColor;
        private Sucursal sucursal; // Definir la sucursal actual
        private readonly SucursalRepository _sucursalRepository;

        public UserControlSucursal(SucursalRepository sucursalRepository)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(UserControlSucursal_Paint);
            pbEditar.MouseEnter += new EventHandler(pbEditar_MouseEnter);
            pbEditar.MouseLeave += new EventHandler(pbEditar_MouseLeave);
            pbEliminar.MouseEnter += new EventHandler(pbEliminar_MouseEnter);
            pbEliminar.MouseLeave += new EventHandler(pbEliminar_MouseLeave);

            _sucursalRepository = sucursalRepository; // Inyección del repositorio
        }

        private void UserControlSucursal_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 1;
            int radius = 10;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius - borderWidth, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius - borderWidth, Height - radius - borderWidth, radius, radius, 0, 90);
            path.AddArc(0, Height - radius - borderWidth, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            using (Pen pen = new Pen(Color.Black, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public void AsignarColorOriginal(Color color)
        {
            originalBackColor = color;
            this.BackColor = color;
        }

        public void CargarDatosSucursal(Sucursal sucursal)
        {
            this.sucursal = sucursal; // Asignar la sucursal actual
            lblUbicacion.Text = sucursal.UbicacionSucursal;
            lblDireccion.Text = sucursal.DireccionSucursal;
        }

        private void pbEditar_MouseEnter(object sender, EventArgs e)
        {
            pbEditar.BackColor = ControlPaint.Light(this.BackColor);
        }

        private void pbEditar_MouseLeave(object sender, EventArgs e)
        {
            pbEditar.BackColor = originalBackColor;
        }

        private void pbEliminar_MouseEnter(object sender, EventArgs e)
        {
            pbEliminar.BackColor = ControlPaint.Light(this.BackColor);
        }

        private void pbEliminar_MouseLeave(object sender, EventArgs e)
        {
            pbEliminar.BackColor = originalBackColor;
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de edición
            frmEditarSucursal editarForm = new frmEditarSucursal(sucursal); // Pasar la sucursal actual
            DialogResult result = editarForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Obtener la sucursal actualizada del formulario de edición
                Sucursal actualizada = editarForm.SucursalActualizada;

                // Recargar los datos actualizados en el UserControl
                CargarDatosSucursal(actualizada);
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            if (sucursal != null && MessageBox.Show("¿Estás seguro de eliminar esta sucursal?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _sucursalRepository.EliminarSucursal(sucursal.IdSucursal);

                // Eliminar el control del formulario
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
