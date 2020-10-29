namespace FinalPOODef
{
    abstract class Habitacion
    {
        public enum estadoOcupacion { DISPONIBLE, RESERVADO, OCUPADO };
        private estadoOcupacion estadoDeOcupacion;
        protected short nroHabitacion;
        protected double costo = 0;

        public short NroHabitacion { get => nroHabitacion; }
        public double Costo { get => costo; }
        public estadoOcupacion EstadoDeOcupacion { get => estadoDeOcupacion; set => estadoDeOcupacion = value; }

        public Habitacion(short nroHabitacion)
        {
            estadoDeOcupacion = estadoOcupacion.DISPONIBLE;
            this.nroHabitacion = nroHabitacion;
        }

        public Habitacion()
        {
        }

    }
}
