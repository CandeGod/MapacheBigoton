using MapacheBigoton.Class;
using MapacheBigoton.Connection;
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
    public partial class frmAgregarSucursal : Form
    {

        private readonly SucursalRepository _sucursalRepository;
        public frmAgregarSucursal()
        {
            InitializeComponent();
            _sucursalRepository = new SucursalRepository(new DatabaseConnection());
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            Sucursal nuevaSucursal = new Sucursal
            {
                UbicacionSucursal = txtUbicacion.Text,
                DireccionSucursal = txtDireccion.Text
            };

            // Guardar la nueva sucursal en el repositorio
            _sucursalRepository.AgregarSucursal(nuevaSucursal);

            // Cerrar el formulario y devolver DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
