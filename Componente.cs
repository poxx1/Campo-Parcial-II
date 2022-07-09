using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialLastra
{
    public abstract class Componente
    {
        private string _nombre;

        public Componente(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre { get { return _nombre; } }
        public abstract void AgregarHijo(Componente componente);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerCapacidad { get; }
    }
}
