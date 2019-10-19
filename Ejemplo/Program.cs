using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p0 = new Persona("Pepito Flores", 67);

            // Pepito cobra la jubilacion
            p0.cobrar(8000);

            // Pepito paga Netflix
            p0.pagar(500);

            // Muestra el saldo restante de pepito
            p0.verSaldo();

            Persona p1 = new Persona("Jorge Rodriguez", 30);

            // Jorge hace ejercicio gastando 70 de energia
            p1.hacerEjercicio(70);

            // Jorge duerme un par de horas recuperando 30 de energia
            p1.dormir(30);

            // Muestra la energia de Jorge
            p1.verEnergia();
            Console.ReadLine();

        }
    }
}
