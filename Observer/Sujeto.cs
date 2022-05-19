using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Sujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private Random rnd = new Random();
        private int num;

        public int Numero { get => num; set => num = value; }

        public void Suscribir(IObservador suscrito)
        {
            observadores.Add(suscrito);
        }

        public void Desuscribir(IObservador suscrito)
        {
            observadores.Remove(suscrito);
        }

        public void Notificar()
        {
            foreach (IObservador obs in observadores)
            {
                obs.Actualizar(mensaje);
            }
        }

        public void Accion()
        {
            //se generan números simulando llamadas a clientes

            num = rnd.Next(10);

            if (num % 2 == 0)
            {
                Console.WriteLine("Nuevo valor");
                mensaje = String.Format("El nuevo valor es {0}", num);
                Notificar();
            }
        }
    }
}
