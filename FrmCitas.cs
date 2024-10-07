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
    public partial class FrmCitas : Form
    {
        private readonly CitaRepository _citaRepository;
        private readonly ClienteRepository _clienteRepository;
        private readonly BarberoRepository _barberoRepository;
        private readonly ServicioRepository _serviceRepository;
        private readonly Random _random;
        Sucursal sucursal;

        public FrmCitas(Sucursal sucursal)
        {
            InitializeComponent();
            _citaRepository = new CitaRepository(new DatabaseConnection());
            _barberoRepository = new BarberoRepository(new DatabaseConnection());
            _clienteRepository = new ClienteRepository(new DatabaseConnection());
            _serviceRepository = new ServicioRepository(new DatabaseConnection());
            _random = new Random();
            this.sucursal = sucursal;
            CargarCitas();
        }

        private void CargarCitas()
        {
            List<Cita> citas = _citaRepository.ObtenerCitas(sucursal.IdSucursal);

            // Limpia el panel antes de agregar los controles
            flowLayoutPanel1.Controls.Clear();
            Barber barbero;
            Client client;
            Service service;


            foreach (var cita in citas)
            {
                barbero = _barberoRepository.ObtenerBarbero(cita.idBarber, sucursal.IdSucursal);
                client = _clienteRepository.ObtenerClienteSuc(cita.idClient, sucursal.IdSucursal);
                service = _serviceRepository.ObtenerServicioPorId(cita.idService, sucursal.IdSucursal);
                UserControlCitaAgendada userControl = new UserControlCitaAgendada();
                userControl.CargarDatos(cita, client, barbero, service);
                userControl.Dock = DockStyle.Top;
                // Asigna un color aleatorio al fondo del control
                userControl.BackColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            frmAgendar frmAgendar = new frmAgendar(sucursal);
            frmAgendar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }
    }
}
