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
    public partial class FrmClientes : Form
    {
        private readonly ClientesRepository repository;
        public FrmClientes()
        {
            InitializeComponent();
            repository = new ClientesRepository(new DatabaseConnection());
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Client> clientes = repository.ObtenerClientes();
            dataGridView1.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client c = new Client
            {
                NombreCliente = txtCliente.Text,
                TelefonoCliente = txtTelefono.Text
            };

            repository.AgregarCliente(c);

            CargarClientes();
        }
    }
}
