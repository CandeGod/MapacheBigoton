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
    public partial class FrmAgregarServicio : Form
    {
        private readonly ServicioRepository _servicioRepository;
        private readonly FrmServicios _frmServicios;  // Referencia a FrmServicios

        public FrmAgregarServicio(FrmServicios frmServicios)
        {
            InitializeComponent();
            _servicioRepository = new ServicioRepository(new DatabaseConnection());
            _frmServicios = frmServicios;  // Asigna la referencia pasada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text) ||
                string.IsNullOrWhiteSpace(richDescripcionServicio.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioServicio.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de agregar un servicio.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el costo sea un número válido
            if (!decimal.TryParse(txtPrecioServicio.Text, out decimal costoServicio))
            {
                MessageBox.Show("El costo del servicio debe ser un número válido.", "Error en el costo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo objeto Service
            Service nuevoServicio = new Service
            {
                NombreServicio = txtNombreServicio.Text.Trim(),
                DescripcionServicio = richDescripcionServicio.Text.Trim(),
                CostoServicio = costoServicio
            };

            // Llamar al método AgregarServicio del repositorio
            try
            {
                _servicioRepository.AgregarServicio(nuevoServicio);

                MessageBox.Show("El servicio ha sido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Llamar al método CargarServicios() del formulario FrmServicios para actualizar la lista
                _frmServicios.CargarServicios();

                // Limpiar los campos después de agregar el servicio
                txtNombreServicio.Clear();
                richDescripcionServicio.Clear();
                txtPrecioServicio.Clear();

                // Cerrar el formulario después de agregar el servicio
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}