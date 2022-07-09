using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialLastra
{
    public class Archivo : Componente
    {
        //No implemento Hijos
        //Violo el principio de Liskov substitucion (segun Battaglia es segregacion de Interfaces).
        int _capacidad;
        public int capacidad { get { return _capacidad; } }
        public Archivo(string nombre, int capacidad) : base(nombre) //Usa el constructor de la clase Componente
        {
            _capacidad = capacidad;
        }
        public override int ObtenerCapacidad
        {
            get
            {
                return capacidad;
            }
        }
        public override void AgregarHijo(Componente componente) { }
        public override IList<Componente> ObtenerHijos()
        {
            return null; //Al no tener hijos, nunca voy a poder debolver uno.
        }
    }
}
