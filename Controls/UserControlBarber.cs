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
    public partial class UserControlBarber : UserControl
    {
        public UserControlBarber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlBarber_Load(object sender, EventArgs e)
        {

        }
        public void CargarDatos(Barber barbero)
        {
            // Asigna los datos del barbero a los controles del UserControl
            lbBarber.Text = barbero.NombreBarbero;
            lblIdBarbero.Text = barbero.IdBarbero.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
