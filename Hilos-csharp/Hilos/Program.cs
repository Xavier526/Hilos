using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hilos
{

    class EjemploHilo
    {

        private string Nombre;
        private int Tiempo;

        public EjemploHilo(string Nombre, int Tiempo)
        {
           this.Nombre = Nombre;
           this.Tiempo = Tiempo;
        }

        // Esta es la función que se ejecuta en un hilo
        // Imprime el nombre del hilo y luego espera un tiempo fijo
        public void ejecutar()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Nombre + ": " + i);
                Thread.Sleep(Tiempo);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            // El hilo A es más lento, imprime cada 500 ms
            // El hilo B es más rápido, imprime cada 200 ms
            // El hilo B debe acabar antes de contar a 10
            EjemploHilo hilo1 = new EjemploHilo("Hilo A", 500);
            EjemploHilo hilo2 = new EjemploHilo("Hilo B", 200);

            Thread th1 = new Thread(new ThreadStart(hilo1.ejecutar));
            Thread th2 = new Thread(new ThreadStart(hilo2.ejecutar));

            th1.Start();
            th2.Start();

        }
    }
}
