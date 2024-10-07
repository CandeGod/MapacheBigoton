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
        public Sucursal sucursal;
        public EventHandler btnSeleccionarSuc;
        public SucursalControl(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
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
            if (btnSeleccionarSuc != null)
            {
                btnSeleccionarSuc(this, e);
            }
        }
    }
}
