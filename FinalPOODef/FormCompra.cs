using System;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class FormCompra : Form
    {
        Administracion admin = null;
        internal FormCompra(Administracion admin)
        {
            InitializeComponent();
            this.admin = admin;
            foreach (var ocupada in admin.Reservas)
            {
                if (ocupada.Estado == Reserva.estadoreserva.Ocupado)
                {
                    lsbReservas.Items.Add(ocupada);
                }
            }
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lsbitemsCompra.Visible = false;
            lsbDisponibles.Visible = false;
            lsbCompras.Visible = false;
            btnCrearCompra.Visible = false;
            btnAñadirACompra.Visible = false;
            nmrCantidad.Visible = false;
            //llenar productos
            lsbDisponibles.Items.Add(new Servicio("Servicio a la habitacion", Item.categoriacompra.habitacion));
            lsbDisponibles.Items.Add(new Servicio("Servicio de lavanderia", Item.categoriacompra.lavanderia));
            lsbDisponibles.Items.Add(new Servicio("Servicio de planchada", Item.categoriacompra.planchada));
            lsbDisponibles.Items.Add(new Producto("Desayuno", Item.categoriacompra.desayuno));
            lsbDisponibles.Items.Add(new Producto("Almuerzo", Item.categoriacompra.almuerzo));
            lsbDisponibles.Items.Add(new Producto("Cena", Item.categoriacompra.cena));
            lsbDisponibles.Items.Add(new Producto("Kit de aseo", Item.categoriacompra.kitaseo));
            lsbDisponibles.Items.Add(new Producto("Bata", Item.categoriacompra.bata));
            lsbDisponibles.Items.Add(new Producto("Licor", Item.categoriacompra.licor));
            lsbDisponibles.Items.Add(new Producto("Vino", Item.categoriacompra.vino));
            lsbDisponibles.Items.Add(new Producto("Gaseosa", Item.categoriacompra.gaseosa));
            lsbDisponibles.Items.Add(new Producto("Agua", Item.categoriacompra.agua));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lsbReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            lsbitemsCompra.Visible = true;
            lsbCompras.Enabled = false;
            lsbitemsCompra.Enabled = false;
            lsbDisponibles.Visible = true;
            lsbCompras.Visible = true;
            btnCrearCompra.Visible = true;
            btnAñadirACompra.Visible = true;
            nmrCantidad.Visible = true;
            lsbCompras.Items.Clear();
            lsbitemsCompra.Items.Clear();
            foreach (var reserva in admin.Reservas)
            {
                if (reserva == (Reserva)lsbReservas.SelectedItem)
                {
                    foreach (var compra in reserva.Compras)
                    {
                        lsbCompras.Items.Add(compra);
                    }
                    break;
                }
            }
        }

        private void btnAñadirACompra_Click(object sender, EventArgs e)
        {
            if (lsbDisponibles.SelectedIndex != -1)
            {
                lsbitemsCompra.Items.Add(new ItemComprado((Item)lsbDisponibles.SelectedItem, (short)nmrCantidad.Value));
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }
        }

        private void btnCrearCompra_Click(object sender, EventArgs e)
        {
            if (lsbitemsCompra.Items.Count != 0 && lsbReservas.SelectedIndex != -1)
            {
                Compra compra = new Compra();
                for (int i = 0; i < lsbitemsCompra.Items.Count; i++)
                {
                    Item item = ((ItemComprado)lsbitemsCompra.Items[i]).Item;
                    short cant = ((ItemComprado)lsbitemsCompra.Items[i]).Cantidad;

                    compra.AñadirCompras(item, cant, ((Reserva)lsbReservas.SelectedItem).Usuario.EsColombiano);
                }
                foreach (var reserva in admin.Reservas)
                {
                    if (reserva == (Reserva)lsbReservas.SelectedItem)
                    {

                        reserva.Comprar(compra);
                        lsbCompras.Items.Add(compra);
                        break;
                    }
                }
                compra = null;
            }
            lsbitemsCompra.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
