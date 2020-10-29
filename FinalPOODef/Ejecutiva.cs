namespace FinalPOODef
{
    class Ejecutiva : Habitacion
    {
        public Ejecutiva()
        {
            costo = 350000;
        }

        public Ejecutiva(short nroHabitacion) : base(nroHabitacion)
        {

            costo = 350000;

        }
        public override string ToString()
        {
            return "Ejecutiva - " + this.Costo;
        }
    }
}
