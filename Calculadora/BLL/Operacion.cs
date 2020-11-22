using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.BLL
{
    class Operacion
    {
        int numero1;
        int numero2;

        public Operacion(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int sumarNumeros(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        public int dividirNumeros(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }

        public int restarNumeros(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public int multiplicarNumeros(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
    }
}
