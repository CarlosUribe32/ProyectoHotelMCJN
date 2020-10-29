namespace FinalPOODef
{
    class Suite : Habitacion
    {
        public Suite()
        {
            costo = 500000;
        }

        public Suite(short nroHabitacion) : base(nroHabitacion)
        {
            costo = 500000;
        }
        public override string ToString()
        {
            return "Suite - " + this.Costo;
        }
    }
}
