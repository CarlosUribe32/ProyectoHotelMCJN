namespace FinalPOODef
{
    class Producto : Item
    {
        public Producto(string nombre, categoriacompra categoria) : base(nombre, categoria)
        {
            if (categoria == categoriacompra.desayuno)
                costo = 15000;
            else if (categoria == categoriacompra.almuerzo)
                costo = 25000;
            else if (categoria == categoriacompra.cena)
                costo = 20000;
            else if (categoria == categoriacompra.kitaseo)
                costo = 9000;
            else if (categoria == categoriacompra.bata)
                costo = 70000;
            else if (categoria == categoriacompra.licor)
                costo = 25000;
            else if (categoria == categoriacompra.vino)
                costo = 50000;
            else if (categoria == categoriacompra.agua)
                costo = 3500;
            else if (categoria == categoriacompra.gaseosa)
                costo = 3000;
            iva = 0.19;
        }
    }
}
