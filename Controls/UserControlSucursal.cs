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
        public Sucursal Sucursal { get; private set; }
        public event EventHandler SucursalClicked;

        private Color originalBackColor;
        private Sucursal sucursal;
        private readonly SucursalRepository _sucursalRepository;
        private bool isCitasFormOpen = false; // Bandera para verificar si el formulario de citas está abierto

        public UserControlSucursal(SucursalRepository sucursalRepository)
        {
            InitializeComponent();

            // Asignar el evento Click a todos los controles hijos
            AssignClickEvent(this);

            this.Paint += new PaintEventHandler(UserControlSucursal_Paint);
            pbEditar.MouseEnter += new EventHandler(pbEditar_MouseEnter);
            pbEditar.MouseLeave += new EventHandler(pbEditar_MouseLeave);
            pbEliminar.MouseEnter += new EventHandler(pbEliminar_MouseEnter);
            pbEliminar.MouseLeave += new EventHandler(pbEliminar_MouseLeave);

            _sucursalRepository = sucursalRepository; // Inyección del repositorio
        }

        // Método para asignar el evento Click a todos los controles hijos y al propio UserControl
        private void AssignClickEvent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Para cada control hijo, asignamos el evento Click
                control.Click += new EventHandler(UserControl_Click);
                if (control.HasChildren)
                {
                    // Recursivamente asignar a los controles hijos
                    AssignClickEvent(control);
                }
            }

            // También asignamos el evento Click al propio UserControl
            this.Click += new EventHandler(UserControl_Click);
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
            Sucursal = sucursal;
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
            frmEditarSucursal editarForm = new frmEditarSucursal(sucursal);
            DialogResult result = editarForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Sucursal actualizada = editarForm.SucursalActualizada;
                CargarDatosSucursal(actualizada);
                MessageBox.Show("Sucursal actualizada correctamente.");
            }
            else
            {
                MessageBox.Show("No se realizaron cambios en la sucursal.");
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            if (sucursal != null && MessageBox.Show("¿Estás seguro de eliminar esta sucursal?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _sucursalRepository.EliminarSucursal(sucursal.IdSucursal);
                    this.Parent.Controls.Remove(this);
                    MessageBox.Show("Sucursal eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la sucursal: " + ex.Message);
                }
            }
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            // Evitar la apertura del formulario si el clic proviene de los PictureBox
            if (sender == pbEditar || sender == pbEliminar)
            {
                return; // No hacer nada si el clic proviene de los PictureBox
            }

            // Solo abrir el formulario si no está ya abierto
            if (!isCitasFormOpen)
            {
                try
                {
                    isCitasFormOpen = true; // Establecer la bandera para evitar múltiples aperturas
                    if (sucursal != null)
                    {
                        FrmCitas frmCitas = new FrmCitas(sucursal);
                        frmCitas.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No hay sucursal seleccionada.");
                    }
                }
                finally
                {
                    isCitasFormOpen = false; // Restablecer la bandera cuando se cierra el formulario
                }
            }
        }

    }
}
