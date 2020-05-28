using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.Beep();

            Thread.Sleep(2000);

            CajadeAhorro cuenta01 = new CajadeAhorro(123, "A", "HSBC", 1, "PEPE", 0);
            cuenta01.MostrarCajadeAhorro();
            Console.ReadKey();

            CajadeAhorro cuenta02 = new CajadeAhorro(124, "B", "HSBC", 2, "JUAN", 500f);
            cuenta02.MostrarCajadeAhorro();
            Console.ReadKey();

            CuentaCorriente cuenta03 = new CuentaCorriente(235, "C", "Banco Ciudad", 3, "JORGE", 1.500f, 0);
            cuenta03.MostrarCuentaCorriente();
            Console.ReadKey();

            CuentaCorriente cuenta04 = new CuentaCorriente(236, "D", "Banco Ciudad", 4, "MARIANA", 2000f, 0);
            cuenta04.MostrarCuentaCorriente();
            Console.ReadKey();

        }
    }
}
