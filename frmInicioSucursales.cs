using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using MapacheBigoton.Controls;
using MapacheBigoton.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MapacheBigoton
{
    public partial class frmInicioSucursales : Form
    {
        private readonly SucursalRepository _sucursalRepository;
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

        private int colorIndex = 0; // Índice para rastrear el color actual

        public frmInicioSucursales()
        {
            InitializeComponent();
            _sucursalRepository = new SucursalRepository(new DatabaseConnection());
            CargarSucursales();
        }

        public void CargarSucursales()
        {
            // Obtener lista de sucursales desde el repositorio
            List<Sucursal> sucursales = _sucursalRepository.ObtenerSucursales();
            flpSucursales.Controls.Clear();

            // Crear un control de usuario por cada sucursal
            foreach (Sucursal sucursal in sucursales)
            {
                // Pasar el repositorio al UserControl para las operaciones de eliminar
                UserControlSucursal userControlSucursal = new UserControlSucursal(_sucursalRepository);
                userControlSucursal.CargarDatosSucursal(sucursal);

                // Asignar el color en secuencia
                Color assignedColor = colores[colorIndex];
                userControlSucursal.AsignarColorOriginal(assignedColor);

                // Incrementar el índice y reiniciarlo si llega al final de la lista
                colorIndex = (colorIndex + 1) % colores.Count;

                // Manejar eventos de edición y eliminación desde aquí si es necesario
                userControlSucursal.Dock = DockStyle.Top;

                // Agregar control de sucursal al panel de flujo
                flpSucursales.Controls.Add(userControlSucursal);
            }
        }

        // Método opcional para recargar las sucursales, por ejemplo, después de editar o eliminar
        public void RecargarSucursales()
        {
            CargarSucursales();
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            frmAgregarSucursal agregarSucursalForm = new frmAgregarSucursal();

            // Mostrar el formulario como un cuadro de diálogo
            if (agregarSucursalForm.ShowDialog() == DialogResult.OK)
            {
                // Si se ha agregado una sucursal, recargar la lista
                RecargarSucursales();
            }
        }
    }
}
