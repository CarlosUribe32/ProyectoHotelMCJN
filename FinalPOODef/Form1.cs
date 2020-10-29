using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class Form1 : Form
    {
        private Administracion admin;
        public Form1()
        {
            InitializeComponent();
            IAdmonLog log = new TXTFile();
            admin = new Administracion(log);
            admin.CargarDB();

            //admin.GenerarReserva(new Huesped(true, "Julian"), 201);
            //admin.Reservas[0].CheckIn();
            //admin.Reservas[0].Comprar(new Compra());
            //admin.Reservas[0].Compras[0].AñadirCompras(new Servicio("Limpieza de la pieza del cuñao", Item.categoriacompra.habitacion), 2);
        }

        internal Administracion Admin { get => admin; set => admin = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Habitacion> libres = new List<Habitacion>();
            foreach (var habitacion in admin.Habitaciones)
            {
                if (habitacion.EstadoDeOcupacion == Habitacion.estadoOcupacion.DISPONIBLE)
                {
                    libres.Add(habitacion);
                }
            }
            if (libres.Count != 0)
            {
                FormReserva reservas = new FormReserva(this.admin);
                reservas.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay habitaciones libres");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            List<Reserva> reservadas = new List<Reserva>();
            foreach (var reserva in admin.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Reservado)
                {
                    reservadas.Add(reserva);
                }
            }
            if (reservadas.Count != 0)
            {
                CheckIn checkin = new CheckIn(admin);
                checkin.ShowDialog();
            }
            else
            {
                MessageBox.Show("no hay reservas");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            List<Reserva> ocupadas = new List<Reserva>();
            foreach (var reserva in admin.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Ocupado)
                {
                    ocupadas.Add(reserva);
                }
            }
            if (ocupadas.Count != 0)
            {
                CheckOut chekout = new CheckOut(admin);
                chekout.ShowDialog();
            }
            else
                MessageBox.Show("No hay ocupaciones");


        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormCompra comprar = new FormCompra(admin);
            List<Reserva> ocupadas = new List<Reserva>();
            foreach (var reserva in admin.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Ocupado)
                {
                    ocupadas.Add(reserva);
                }
            }
            if (ocupadas.Count != 0)
            {
                comprar.ShowDialog();
            }
            else
                MessageBox.Show("No hay habitaciones ocupadas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLog log = new FormLog();
            log.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancelarReserva cancelar = null;
            List<Reserva> reservadas = new List<Reserva>();
            foreach (var reserva in admin.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Reservado)
                {
                    reservadas.Add(reserva);
                }
            }
            if (reservadas.Count != 0)
            {
                cancelar = new CancelarReserva(admin);
                cancelar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas");
            }
        }
    }
}
