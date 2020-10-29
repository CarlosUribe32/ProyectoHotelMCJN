namespace FinalPOODef
{
    class Servicio : Item
    {
        public Servicio(string nombre, categoriacompra categoria) : base(nombre, categoria)
        {
            if (categoria == categoriacompra.habitacion)
                costo = 5000;
            else if (categoria == categoriacompra.lavanderia)
                costo = 12000;
            else if (categoria == categoriacompra.planchada)
                costo = 9000;
            iva = 0;
        }
    }
}
