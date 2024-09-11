using MapacheBigoton.Connection;
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
    public partial class FrmInicio : Form
    {
        private DatabaseConnection _databaseConnection;
        public FrmInicio()
        {
            InitializeComponent();
            _databaseConnection = new DatabaseConnection();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            var isConnected = _databaseConnection.GetConnection();
            if (isConnected != null && isConnected.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión a la base de datos exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La conexion no se establecio");
            }

        }
    }
}
