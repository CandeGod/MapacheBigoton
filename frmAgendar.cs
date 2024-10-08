using MapacheBigoton.Connection;
using MapacheBigoton.Repository;
using MapacheBigoton.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MapacheBigoton
{
    public partial class frmAgendar : Form
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly BarberoRepository _barberoRepository;
        private readonly ServiceRepository _serviceRepository;
        private readonly CitaRepository _citaRepository;
        private readonly Sucursal _sucursalSeleccionada;

        Client clienteAux;
        List<Client> clientes;
        List<Barber> barberos;
        List<Service> servicios;

        // Constructor que recibe la sucursal seleccionada
        public frmAgendar(Sucursal sucursal)
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository(new DatabaseConnection());
            _barberoRepository = new BarberoRepository(new DatabaseConnection());
            _serviceRepository = new ServiceRepository(new DatabaseConnection());
            _citaRepository = new CitaRepository(new DatabaseConnection());
            _sucursalSeleccionada = sucursal;

            CargarClientes();
            CargarBarberos();
            CargarServicios();
        }

        public void CargarClientes()
        {
            cbClientes.Items.Clear();
            clientes = _clienteRepository.ObtenerClientes();
            foreach (Client cliente in clientes)
            {
                string ncliente = cliente.NombreCliente + ", " + cliente.TelefonoCliente;
                cbClientes.Items.Add(ncliente);
            }
        }

        public void CargarBarberos()
        {
            cbBarberos.Items.Clear();
            barberos = _barberoRepository.ObtenerBarberos();
            foreach (Barber barbero in barberos)
            {
                cbBarberos.Items.Add(barbero.NombreBarbero);
            }
        }

        public void CargarServicios()
        {
            cbServicios.Items.Clear();
            servicios = _serviceRepository.ObtenerServicios();
            foreach (Service servicio in servicios)
            {
                cbServicios.Items.Add(servicio.NombreServicio);
            }
        }

        public void CambiarCliente(Client client)
        {
            this.clienteAux = client;
            string ncliente = clienteAux.NombreCliente + ", " + clienteAux.TelefonoCliente;
            cbClientes.Text = ncliente;
        }

        private void bAgendar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un cliente, barbero y servicio
            if (cbClientes.SelectedIndex == -1 || cbBarberos.SelectedIndex == -1 || cbServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un cliente, barbero y servicio antes de agendar la cita.");
                return;
            }

            // Obtener los datos para agendar la cita
            DateTime fecha = dtFecha.Value;
            int hora = (int)numHora.Value;
            int minutos = (int)numMinu.Value;
            TimeSpan horas = new TimeSpan(hora, minutos, 0);

            clienteAux = clientes.ElementAt(cbClientes.SelectedIndex);
            Barber barbero = barberos.ElementAt(cbBarberos.SelectedIndex);
            Service servicio = servicios.ElementAt(cbServicios.SelectedIndex);

            // Agregar la cita a la base de datos, vinculada con la sucursal seleccionada
            _citaRepository.AgregarCita(horas, fecha, clienteAux.IdCliente, barbero.IdBarbero, servicio.IdServicio, _sucursalSeleccionada.IdSucursal);

            MessageBox.Show("Cita realizada exitosamente.");

            // Cerrar el formulario y devolver OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bBuscarClient_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente(this);
            frm.Show();
        }

        private void frmAgendar_Load(object sender, EventArgs e)
        {
            // Lógica adicional si es necesario cuando se carga el formulario
        }
    }
}
