using System;

namespace calculo_sueldo_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double horas, pago, sueldo; //variables locales para calcular pago por hora
            Console.WriteLine("Ingrese valor de horas trabajadas");//se muestra mensaje donde se pide las horas trabajadas
            horas = Double.Parse(Console.ReadLine());//se guarda en variable el valor de las horas trabajadas
            Console.WriteLine("Ingrese precio por cada hora");//se muestra msg que pide el precio por cada hora
            pago = Double.Parse(Console.ReadLine());//se guarda en variable el precio por hora
            sueldo = pago * horas;//se calcula el sueldo total
            Console.WriteLine("El sueldo es de: " + sueldo);
        }
    }
}
