namespace FinalPOODef
{
    class Sencilla : Habitacion
    {
        public Sencilla()
        {
            costo = 200000;
        }

        public Sencilla(short nroHabitacion) : base(nroHabitacion)
        {
            costo = 200000;
        }
        public override string ToString()
        {
            return "Sencilla - " + this.Costo;
        }
    }
}
