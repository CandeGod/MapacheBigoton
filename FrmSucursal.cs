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
    public partial class FrmSucursal : Form
    {
        private readonly SucursalRepository _sucursalRepository;
        public FrmSucursal()
        {
            InitializeComponent();
            _sucursalRepository = new SucursalRepository(new DatabaseConnection());
            CargarSucursales();
        }

        public void CargarSucursales()
        {
            List <Sucursal> sucursales = _sucursalRepository.ObtenerSucursales();
            flpSucursales.Controls.Clear();
            foreach (var item in sucursales)
            {
                SucursalControl ctrlSuc = new SucursalControl(item);
                flpSucursales.Controls.Add(ctrlSuc);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
