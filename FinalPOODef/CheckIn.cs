using System;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class CheckIn : Form
    {
        Administracion admin = null;
        internal CheckIn(Administracion admin)
        {
            InitializeComponent();
            this.admin = admin;
            foreach (var reserva in admin.Reservas)
            {
                if (reserva.Estado == Reserva.estadoreserva.Reservado)
                {
                    cbReservas.Items.Add(reserva);
                }
            }
            cbReservas.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            foreach (var reserva in admin.Reservas)
            {
                if (reserva == cbReservas.SelectedItem)
                {
                    admin.OcuparReserva(reserva);
                    MessageBox.Show("CheckIn realizado con exito");
                    break;
                }
            }
            Dispose();
        }
    }
}
