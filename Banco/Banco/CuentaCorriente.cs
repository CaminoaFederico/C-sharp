using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class CuentaCorriente:Banco
    {
        int idcuenta;
        string nombrecliente;
        float saldo;
        float saldonegativo;
        float nuevosaldo;
        float resultado;

        public CuentaCorriente() { }

        public CuentaCorriente(int idc, string tip, string ban, int idcue, string nomb, float sald, float salne)
            : base(idc, tip, ban)
        {

            idcuenta = idcue;
            nombrecliente = nomb;
            saldo = sald;
            saldonegativo = salne;
        }

        public void MostrarCuentaCorriente()
        {
            Console.WriteLine(" Cuenta Corriente: ");
            Console.WriteLine(" El id de la cuenta es: " + idcuenta);
            Console.WriteLine(" El nombre del cliente es: " + nombrecliente);
            Console.WriteLine(" El saldo de la cuenta es: " + saldo);
            Console.WriteLine(" El saldo negativo de la cuenta es: " + saldonegativo);

            Console.WriteLine("Agregue saldo...");
            nuevosaldo = float.Parse(Console.ReadLine());

            resultado = saldo + nuevosaldo;

            if (resultado < 0)
            {
                Console.WriteLine("Usted no puede sacar más plata de la que dispone.");
            }
            else
            {
                Console.WriteLine("El nuevo saldo es: " + resultado);
            }
        }
    }
}
