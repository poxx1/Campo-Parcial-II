using ParcialLastra;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialLastra
{
    public class Directorio : Componente
    {
        private List<Componente> _hijos;
        public Directorio(string nombre) : base(nombre) //Base se lo envia a la clase Base >> osea Componente
        {
            _hijos = new List<Componente>();
        }

        public override int ObtenerCapacidad
        {
            get
            {
                int t = 0; //Capacidad de los hijos

                foreach (var hijo in _hijos)
                {
                    t += hijo.ObtenerCapacidad;
                }
                return t;
            }
        }
        public override void AgregarHijo(Componente componente)
        {
            _hijos.Add(componente);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos.ToArray();
        }
    }
} 