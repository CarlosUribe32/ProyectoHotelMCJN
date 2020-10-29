using System.Collections.Generic;
using System.IO;

namespace FinalPOODef
{

    class Factura
    {
        private double descuentoUsuario;
        private double subtotalCOmpras;
        private double vrlIVA;
        private double vlrTotal;
        private double vlrHabitacion;

        public Factura(double descuentoUsuario, double subtotalCOmpras, double vrlIVA, double vlrHabitacion, Persona usuario, List<Compra> compras, int diasOcupacion)
        {
            this.descuentoUsuario = descuentoUsuario;
            this.subtotalCOmpras = subtotalCOmpras;
            this.vrlIVA = vrlIVA;
            this.vlrHabitacion = vlrHabitacion;
            GenerarFactura(usuario, compras, diasOcupacion);
        }

        private void GenerarFactura(Persona usuario, List<Compra> compras, int diasOcupacion)
        {
            StreamWriter writer = File.AppendText("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\Factura\\Factura.txt");
            writer.WriteLine("Informacion del usuario: " + usuario.Nombre + " con CC: " + usuario.Id + " estadia de " + diasOcupacion + " dias" + "\nCompró: ");
            foreach (var compra in compras)
            {
                writer.Write(compra.ToString() + "\n");
                foreach (var item in compra.Items)
                {
                    writer.WriteLine("   " + item.ToString());
                }
            }
            vlrTotal = vlrTotal + vlrHabitacion * (1 + vrlIVA) * diasOcupacion;
            vlrTotal = vlrTotal + subtotalCOmpras;
            vlrTotal = vlrTotal * (1 - descuentoUsuario);
            writer.WriteLine("IVA = " + (vrlIVA*100) + "% | Subtotal compras = " + subtotalCOmpras + " | Valor de habitacion = "
                + vlrHabitacion + "/dia | Descuento = "+(int)(descuentoUsuario*100)+"% |Valor total = " + vlrTotal);
            writer.WriteLine("-----------------------------------------------------------------------------------------------------");
            writer.Close();
        }

        public double DescuentoUsuario { get => descuentoUsuario; }
        public double SubtotalCOmpras { get => subtotalCOmpras; }
        public double VrlIVA { get => vrlIVA; }
        public double VlrTotal { get => vlrTotal; }
        public double VlrHabitacion { get => vlrHabitacion; }
    }
}
