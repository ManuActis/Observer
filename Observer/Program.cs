using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo un sujeto
            Sujeto sujetoA = new Sujeto();

            //creo observadores para que se suscriban al sujeto
            Observador obsA = new Observador("ObservadorA", sujetoA);
            Observador obsB = new Observador("ObservadorB", sujetoA);
            Observador obsC = new Observador("ObservadorC", sujetoA);
            
            //llamo a la Accion para generar nros simulando llamadas de clientes
            for(int n=0; n<4; n++)
            {
                sujetoA.Accion();
            }

            //simulacion se desuscribe un dispositivo de ese orden de llamados
            sujetoA.Desuscribir(obsC);
            Console.WriteLine("Desuscrito el dispositivo {0}", obsC.ToString());

            //llamo a la Accion para generar nros simulando llamadas de clientes
            for (int n = 0; n < 4; n++)
            {
                sujetoA.Accion();
            }

            Console.ReadLine();

        }
    }
}
