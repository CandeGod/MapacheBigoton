using MapacheBigoton.Connection;
using MapacheBigoton.Repository;
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

namespace MapacheBigoton
{
    public partial class frmBuscarCliente : Form
    {
        private readonly ClienteRepository _clienteRepository;
        frmAgendar frmAg;
        Client cliente;
        public frmBuscarCliente(frmAgendar frmAg)
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository(new DatabaseConnection());
            this.frmAg = frmAg;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            cliente = _clienteRepository.ObtenerCliente(tbTel.Text, frmAg.sucursal.IdSucursal);
            if (cliente.NombreCliente != null)
            {
                txtNom.Text = cliente.NombreCliente;
                bSelect.Enabled = true;
            }
            else
            {
                MessageBox.Show("No encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            frmAg.CambiarCliente(cliente);
            this.Close();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
