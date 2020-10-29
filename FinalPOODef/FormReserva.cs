using System;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class FormReserva : Form
    {
        Administracion admin = null;
        internal FormReserva(Administracion admin)
        {
            this.admin = admin;
            InitializeComponent();
            cbtipoHabitacion.Items.Add(new Sencilla());
            cbtipoHabitacion.Items.Add(new Ejecutiva());
            cbtipoHabitacion.Items.Add(new Suite());
            chkSi.Checked = true;
            chkHuesped.Checked = true;
            cbtipoHabitacion.SelectedIndex = 0;
            cbhabLibres.SelectedIndex = 0;
        }

        private void cbtipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtipoHabitacion.SelectedItem.ToString().Equals("Sencilla - 200000"))
            {
                cbhabLibres.Items.Clear();
                for (int i = 0; i < 30; i++)
                {
                    if (admin.Habitaciones[i].EstadoDeOcupacion == Habitacion.estadoOcupacion.DISPONIBLE)
                    {
                        cbhabLibres.Items.Add(admin.Habitaciones[i].NroHabitacion);
                    }
                }
                if (cbhabLibres.Items.Count != 0)
                {
                    cbhabLibres.SelectedIndex = 0;
                }
            }
            else if (cbtipoHabitacion.SelectedItem.ToString().Equals("Ejecutiva - 350000"))
            {
                cbhabLibres.Items.Clear();
                for (int i = 30; i < 40; i++)
                {
                    if (admin.Habitaciones[i].EstadoDeOcupacion == Habitacion.estadoOcupacion.DISPONIBLE)
                    {
                        cbhabLibres.Items.Add(admin.Habitaciones[i].NroHabitacion);
                    }
                }
                if (cbhabLibres.Items.Count != 0)
                {
                    cbhabLibres.SelectedIndex = 0;
                }
            }
            else
            {
                cbhabLibres.Items.Clear();
                for (int i = 40; i < 45; i++)
                {
                    if (admin.Habitaciones[i].EstadoDeOcupacion == Habitacion.estadoOcupacion.DISPONIBLE)
                    {
                        cbhabLibres.Items.Add(admin.Habitaciones[i].NroHabitacion);
                    }
                }
                if (cbhabLibres.Items.Count != 0)
                {
                    cbhabLibres.SelectedIndex = 0;
                }
            }

        }

        private void FormReserva_Load(object sender, EventArgs e)
        {

        }

        private void chkSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSi.Checked)
            {
                chkNo.Checked = false;
            }
            else
                chkNo.Checked = true;
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked)
            {
                chkSi.Checked = false;
            }
            else
                chkSi.Checked = true;
        }

        private void chkHuesped_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHuesped.Checked)
            {
                chkCliente.Checked = false;
            }
            else
                chkCliente.Checked = true;
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                chkHuesped.Checked = false;
            }
            else
                chkHuesped.Checked = true;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                bool esColombiano = true;
                bool cliente = false;
                int id = 0;
                Persona usuario = null;
                if (chkNo.Checked)
                {
                    esColombiano = false;
                }
                if (chkCliente.Checked)
                {
                    cliente = true;
                }
                if (txtId.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese su cedula o ID");
                    return;
                }
                else
                {
                    bool esnumero = false;
                    esnumero = int.TryParse(txtId.Text, out id);
                    if (!esnumero)
                    {
                        MessageBox.Show("ingrese un id valido");
                        return;
                    }
                    else
                    {
                        if (id.ToString().Length < 9 || id.ToString().Length > 9)
                        {
                            MessageBox.Show("ingrese un id valido");
                            return;
                        }
                    }
                }
                if (cliente)
                {
                    usuario = new Cliente(esColombiano, txtNombre.Text);
                    usuario.Id = id;
                }
                else
                {
                    usuario = new Huesped(esColombiano, txtNombre.Text);
                    usuario.Id = id;
                }
                if (cbhabLibres.SelectedItem.ToString() != String.Empty)
                {
                    admin.GenerarReserva(usuario, short.Parse(cbhabLibres.SelectedItem.ToString()), (int)nmrDias.Value);
                    MessageBox.Show("Reserva exitosa");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("No se puede crear la reserva sin un numero de habitacion");
                }
            }
            else
            {
                MessageBox.Show("Ingrese nombre por favor");
            }
        }
    }
}
