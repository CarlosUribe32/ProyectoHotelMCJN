using System;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class CancelarReserva : Form
    {
        Administracion administracion = null;
        internal CancelarReserva(Administracion administracion)
        {
            InitializeComponent();
            this.administracion = administracion;
            foreach (var reserva in administracion.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Reservado)
                {
                    cbxReservas.Items.Add(reserva);
                }
            }
            cbxReservas.SelectedIndex = 0;
        }

        private void CancelarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (var reserva in administracion.Reservas)
            {
                if (reserva == cbxReservas.SelectedItem)
                {
                    administracion.CancelarReserva(reserva);
                    MessageBox.Show("Reserva cancelada");
                    break;
                }
            }
            Dispose();
        }
    }
}
