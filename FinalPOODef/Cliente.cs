namespace FinalPOODef
{
    class Cliente : Persona
    {
        public Cliente(bool esColombiano, string nombre) : base(esColombiano, nombre)
        {
            descuentoSemanal = 0.1F;
        }
    }
}
