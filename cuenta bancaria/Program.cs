using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cuenta_bancaria.Cuenta;

namespace cuenta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuenta = new CuentaBancaria(1000);

            Console.WriteLine("El saldo actual es: " + cuenta.Saldo);

            IExtraible operacionDebito = cuenta;
            bool debitoExitoso = operacionDebito.Debitar(500);
            if (debitoExitoso)
            {
                Console.WriteLine("Débito exitoso. Nuevo saldo: " + cuenta.Saldo);
            }
            else
            {
                Console.WriteLine("No se pudo realizar el débito.");
            }

            IDepositable operacionCredito = cuenta;
            bool creditoExitoso = operacionCredito.Acreditar(1000);
            if (creditoExitoso)
            {
                Console.WriteLine("Crédito exitoso. Nuevo saldo: " + cuenta.Saldo);
            }
            else
            {
                Console.WriteLine("No se pudo realizar el crédito.");
            }


        }
    }
}
