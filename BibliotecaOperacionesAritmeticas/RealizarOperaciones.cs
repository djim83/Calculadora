using System;

namespace BibliotecaOperacionesAritmeticas
{
    public class RealizarOperaciones
    {
        int num1;
        int num2;

        public RealizarOperaciones(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int mostrarPotencia(int num1, int num2)
        {
            int resultado = 1;

            for (int i = 0; i < num2; i++)
            {
                resultado = resultado * num1;
            }

            return resultado;
        }

        public double mostrarRaizCuadrada(int num1)
        {
            double resultado = Math.Sqrt(num1);
            return resultado;
        }

    }

   
}
