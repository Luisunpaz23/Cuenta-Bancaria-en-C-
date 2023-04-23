using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_bancaria
{
    internal class Cuenta
    {

        public class CuentaBancaria : IDepositable, IExtraible
        {
            private decimal saldo;

            public CuentaBancaria(decimal saldo)
            {
               this. saldo = saldo;
            }

            public bool Debitar(decimal importe)
            {
                if (importe > 0 && saldo >= importe)
                {
                    saldo -= importe;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Acreditar(decimal importe)
            {
                if (importe > 0)
                {
                    saldo += importe;
                    return true;
                }
                else
                {
                    return false;
                }
            }

           

            public decimal Saldo
            {
                get { return saldo; }
            }
        }




    }
}
