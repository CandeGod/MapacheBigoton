using MapacheBigoton.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapacheBigoton.Controls
{
    public partial class SucursalControl : UserControl
    {
        Sucursal sucursal;
        public SucursalControl(Sucursal sucursal)
        {
            this.sucursal = sucursal;
            InitializeComponent();
            LlenarSuc();
        }

        public void LlenarSuc()
        {
            txtIdSuc.Text = sucursal.IdSucursal + "";
            txtNomSuc.Text = sucursal.NombreSucursal;
            txtEdoSuc.Text = sucursal.Estado;
            txtMunSuc.Text = sucursal.Municipio;
            txtCalleSuc.Text = sucursal.Calle;
        }

        private void bSeleccionarSuc_Click(object sender, EventArgs e)
        {

        }
    }
}
