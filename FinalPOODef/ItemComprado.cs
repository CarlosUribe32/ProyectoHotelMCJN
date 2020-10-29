using System;

namespace FinalPOODef
{
    class ItemComprado
    {
        private Item item;
        private short cantidad;

        public ItemComprado(Item item, short cantidad)
        {
            this.item = item ?? throw new ArgumentNullException(nameof(item));
            this.cantidad = cantidad;
        }

        public short Cantidad { get => cantidad; }
        public Item Item { get => item; }

        public override string ToString()
        {
            return item.Nombre + ": " + cantidad;
        }
    }
}
