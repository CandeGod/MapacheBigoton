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
    public partial class frmAgendar : Form
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly BarberoRepository _barberoRepository;
        private readonly ServiceRepository _serviceRepository;
        private readonly CitaRepository _citaRepository;
        Client clienteAux;
        List<Client> clientes;
        List<Barber> barberos;
        List<Service> servicios;
        public Sucursal sucursal;

        public frmAgendar(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            _clienteRepository = new ClienteRepository(new DatabaseConnection());
            _barberoRepository = new BarberoRepository(new DatabaseConnection());
            _serviceRepository = new ServiceRepository(new DatabaseConnection());
            _citaRepository = new CitaRepository(new DatabaseConnection());
            CargarClientes();
            CargarBarberos();
            CargarServicios();
        }

        public void CargarClientes()
        {
            cbClientes.Items.Clear();
            clientes = _clienteRepository.ObtenerClientes(sucursal.IdSucursal);
            string ncliente = "";
            foreach (Client cliente in clientes)
            {
                ncliente = cliente.NombreCliente + ", " + cliente.TelefonoCliente;
                cbClientes.Items.Add(ncliente);
            }
        }

        public void CargarBarberos()
        {
            cbBarberos.Items.Clear();
            barberos = _barberoRepository.ObtenerBarberos(sucursal.IdSucursal);
            foreach (Barber barbero in barberos)
            {
                cbBarberos.Items.Add(barbero.NombreBarbero);
            }
        }

        public void CargarServicios()
        {
            cbServicios.Items.Clear();
            servicios = _serviceRepository.ObtenerServicios(sucursal.IdSucursal);
            foreach (Service servicio in servicios)
            {
                cbServicios.Items.Add(servicio.NombreServicio);
            }
        }

        private void frmAgendar_Load(object sender, EventArgs e)
        {

        }

        public void CambiarCliente(Client client)
        {
            this.clienteAux = client;
            string ncliente = clienteAux.NombreCliente + ", " + clienteAux.TelefonoCliente;
            cbClientes.Text = ncliente;
        }

        private void bAgendar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtFecha.Value;
            int hora = ((int)numHora.Value);
            int minutos = ((int)numMinu.Value);
            TimeSpan horas = new TimeSpan(hora, minutos, 0);
            clienteAux = clientes.ElementAt(cbClientes.SelectedIndex);
            Barber barbero = barberos.ElementAt(cbBarberos.SelectedIndex);
            Service servicio = servicios.ElementAt(cbServicios.SelectedIndex);
            _citaRepository.AgregarCita(horas, fecha, clienteAux.IdCliente, barbero.IdBarbero, servicio.IdServicio, sucursal.IdSucursal);
            MessageBox.Show("Cita realizada");
        }

        private void bBuscarClient_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente(this);
            frm.Show();
        }
    }
}
