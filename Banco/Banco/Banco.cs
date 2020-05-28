using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class Banco
    {
        int idcuenta;
        string tipocuenta;
        string bancoasociado;

        public Banco() { }

        public Banco(int idc, string tip, string ban)
        {
            idcuenta = idc;
            tipocuenta = tip;
            bancoasociado = ban;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("El id de la cuenta es: " + idcuenta);
            Console.WriteLine("El tipo de cuenta es: " + tipocuenta);
            Console.WriteLine("El banco asociado de la cuenta es: " + bancoasociado);
        }
    }
}
