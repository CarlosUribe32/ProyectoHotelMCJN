using System;
using System.Collections.Generic;

namespace FinalPOODef
{
    class Compra
    {
        private List<ItemComprado> items;
        private DateTime fechacompra;
        private short idcompra;
        private double subtotalcompra;

        public Compra()
        {
            Random rnd = new Random();
            items = new List<ItemComprado>();
            idcompra = (short)rnd.Next(100, 200);
            fechacompra = DateTime.Now;
            subtotalcompra = 0;
        }

        public List<ItemComprado> Items { get => items; set => items = value; }
        public DateTime Fechacompra { get => fechacompra; set => fechacompra = value; }
        public short Idcompra { get => idcompra; set => idcompra = value; }
        public double Subtotalcompra { get => subtotalcompra; set => subtotalcompra = value; }

        public void AñadirCompras(Item item, short cant, bool escolombiano)
        {
            try
            {
                ItemComprado comprado = new ItemComprado(item, cant);
                items.Add(comprado);
                double costoitemcantidad = 0;
                if (escolombiano)
                {
                    costoitemcantidad = item.Costo * cant * (1 + item.Iva);
                    subtotalcompra = subtotalcompra + costoitemcantidad;
                }
                else
                {
                    costoitemcantidad = item.Costo * cant;
                    subtotalcompra = subtotalcompra + costoitemcantidad;
                }
            }
            catch (Exception)
            {
                throw new Exception("Hay un error en el metodo AñadirCompras del metodo Compra");
            }
        }

        public override string ToString()
        {
            return idcompra + "|" + fechacompra.ToString();
        }
    }
}
