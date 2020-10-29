using System;
using System.Collections.Generic;

namespace FinalPOODef
{
    class Reserva
    {
        public enum estadoreserva { Ocupado, Reservado };

        private estadoreserva estado;
        private DateTime fecha;
        private Factura factura;
        private Persona usuario;
        private List<Compra> compras = new List<Compra>();
        private Habitacion habitacion;
        private int diasOcupacion;

        public Reserva(Persona usuario, Habitacion habitacion, int diasOcupacion)
        {
            estado = estadoreserva.Reservado;
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            this.habitacion = habitacion ?? throw new ArgumentNullException(nameof(habitacion));
            this.diasOcupacion = diasOcupacion;
            habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.RESERVADO;
            fecha = new DateTime();
            fecha = DateTime.Now;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Factura Factura { get => factura; }
        public Persona Usuario { get => usuario; }
        public List<Compra> Compras { get => compras; }
        public Habitacion Habitacion { get => habitacion; }
        public estadoreserva Estado { get => estado; set => estado = value; }
        public int DiasOcupacion { get => diasOcupacion; }

        public void CheckIn()
        {
            try
            {
                estado = estadoreserva.Ocupado;
                habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.OCUPADO;
            }
            catch (Exception e)
            {
                throw new Exception("error en la clase reserva metodo checkin, contacte al soporte tecnico\nDetalles: " + e.Message);
            }
        }
        public Factura CheckOut()
        {
            try
            {
                double subtotal = 0;
                foreach (var compra in Compras)
                {
                    subtotal = subtotal + compra.Subtotalcompra;
                }
                double vlrIVA = 0;
                if (usuario.EsColombiano)
                {
                    vlrIVA = 0.19;
                }
                else
                    vlrIVA = 0;
                Factura factura = new Factura(usuario.DescuentoSemanal, subtotal, vlrIVA, habitacion.Costo, usuario, compras, diasOcupacion);
                habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.DISPONIBLE;
                return factura;
            }
            catch (Exception e)
            {

                throw new Exception("error en la clase reserva metodo checkout, contacte al soporte tecnico\nDetalles: " + e.Message);
            }

        }
        public void Comprar(Compra compra)
        {
            try
            {
                IAdmonLog log = new TXTFile();
                compras.Add(compra);
                string comprasinfo = "";
                foreach (var comprado in compra.Items)
                {
                    comprasinfo = comprasinfo + " - " + comprado.Item.Nombre + "-precio unitario: $ " + comprado.Item.Costo + "->" + comprado.Cantidad;
                }
                string info = "Compra hecha por el usuario " + usuario.Nombre + " en " + DateTime.Now.ToString() + "\nCompro:" + comprasinfo;
                log.GuardarLog(info);
            }
            catch (Exception e)
            {
                throw new Exception("error en la clase reserva metodo comprar, contacte al soporte tecnico\nDetalles: " + e.Message);
            }
        }
        public override string ToString()
        {
            return usuario.Nombre + "->" + habitacion.NroHabitacion;
        }
    }
}
