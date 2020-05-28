using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class CajadeAhorro : Banco
    {
        int idcuenta;
        string nombrecliente;
        float saldo;
        float nuevosaldo;
        float resultado;
        float nuevoresultado;

        public CajadeAhorro() { }

        public CajadeAhorro(int idc, string tip, string ban, int idcu, string nom, float sal)
            : base(idc, tip, ban)
        {
            idcuenta = idcu;
            nombrecliente = nom;
            saldo = sal;
        }

        public void MostrarCajadeAhorro()
        {
            Console.WriteLine(" Caja de Ahorro: ");
            Console.WriteLine(" El id de la cuenta es: " + idcuenta);
            Console.WriteLine(" El nombre del cliente es: " + nombrecliente);
            Console.WriteLine(" El saldo de la cuenta es: " + saldo);
            
            Console.WriteLine("Agregue saldo...");
            nuevosaldo = float.Parse(Console.ReadLine());

            resultado = saldo + nuevosaldo;

            Console.WriteLine("El nuevo saldo es: " + resultado);

            while (resultado > 0)
            {

                if (resultado < 0)
                {
                    Console.WriteLine("Usted no puede sacar más plata de la que dispone.");
                }

                Console.WriteLine("Agregue saldo...");
                nuevosaldo = float.Parse(Console.ReadLine());

                nuevoresultado = resultado + nuevosaldo;

                Console.WriteLine("El nuevo saldo es: " + nuevoresultado);
                
            }
   

        }
    }
}
