using System;

namespace FinalPOODef
{
    abstract class Persona
    {
        protected bool esColombiano;
        protected float descuentoSemanal = 0;
        protected string nombre;
        protected long id;

        protected Persona(bool esColombiano, string nombre)
        {
            this.esColombiano = esColombiano;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }

        public bool EsColombiano { get => esColombiano; }
        public float DescuentoSemanal { get => descuentoSemanal; set => descuentoSemanal = value; }
        public string Nombre { get => nombre; }
        public long Id { get => id; set => id = value; }


    }
}
