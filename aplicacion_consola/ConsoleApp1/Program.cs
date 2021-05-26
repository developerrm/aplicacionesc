using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static String nombre;

        class registro
        {
            public void PedirNombre()
            {
                Console.WriteLine("Ingrese su primer nombre");
               nombre= Console.ReadLine();
            }
        }
        class mostrar
        {
            public void MostarNombre()
            {
                Console.WriteLine(nombre);
            }
        }

  
        static void Main(string[] args)
        {
            registro reg = new registro();
            mostrar mos = new mostrar();
            if (nombre==null)
            {
                Console.WriteLine("No hay nombres en variable inicializada.");
                reg.PedirNombre();
                mos.MostarNombre();
            }
                       

        }
    }
}
