using MapacheBigoton.Class;
using System;
using System.Windows.Forms;

namespace MapacheBigoton
{
    public partial class frmEditarSucursal : Form
    {
        public Sucursal SucursalActualizada { get; private set; }
        private Sucursal sucursalOriginal;

        public frmEditarSucursal(Sucursal sucursal)
        {
            InitializeComponent();
            sucursalOriginal = sucursal;

            // Cargar los datos de la sucursal original en los controles del formulario
            txtUbicacion.Text = sucursal.UbicacionSucursal;
            txtDireccion.Text = sucursal.DireccionSucursal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("La ubicación no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si ambos campos son válidos, actualizar la sucursal con los datos editados
            sucursalOriginal.UbicacionSucursal = txtUbicacion.Text;
            sucursalOriginal.DireccionSucursal = txtDireccion.Text;

            // Asignar la sucursal editada a la propiedad SucursalActualizada
            SucursalActualizada = sucursalOriginal;

            // Cerrar el formulario y devolver DialogResult.OK para indicar que se han guardado los cambios
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
