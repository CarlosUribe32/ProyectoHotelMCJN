using System;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class CheckOut : Form
    {
        Administracion admin = null;
        internal CheckOut(Administracion admin)
        {
            InitializeComponent();
            this.admin = admin;
            foreach (var reserva in admin.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Ocupado)
                {
                    cbOcupadas.Items.Add(reserva);
                }
            }
            cbOcupadas.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var reserva in admin.Reservas)
            {
                if (reserva == cbOcupadas.SelectedItem)
                {
                    admin.CancelarReserva(reserva);
                    MessageBox.Show("CheckOut Realizado con exito, mas informacion en la factura");
                    break;
                }
            }
            Dispose();
        }
    }
}
