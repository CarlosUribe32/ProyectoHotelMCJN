namespace FinalPOODef
{
    abstract class Item
    {
        public enum categoriacompra { habitacion, lavanderia, planchada, desayuno, almuerzo, cena, kitaseo, bata, licor, vino, agua, gaseosa };

        protected double costo;
        protected string nombre;
        protected categoriacompra categoria;
        protected double iva;

        protected Item(string nombre, categoriacompra categoria)
        {
            this.nombre = nombre;
            this.categoria = categoria;
        }

        public double Costo { get => costo; }
        public string Nombre { get => nombre; }
        public categoriacompra Categoria { get => categoria; }
        public double Iva { get => iva; }

        public override string ToString()
        {
            return nombre + "-$" + costo;
        }
    }

}
