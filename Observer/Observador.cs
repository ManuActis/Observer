using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;
        public Observador(string pnombre, Sujeto psujeto)
        {
            nombre = pnombre;
            sujeto = psujeto;
            sujeto.Suscribir(this);
        }
        public void Actualizar(string mensaje)
        {
            Console.WriteLine("Pusheando mensaje: {0} a {1}", mensaje, nombre);
        }

        public void ActualizarTraer()
        {
            int numero = sujeto.Numero;
            Console.WriteLine("Traer nro {0} a sujeto {1}", numero, nombre);
        }
    }
}
