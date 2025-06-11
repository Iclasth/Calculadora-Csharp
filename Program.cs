using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraAritimetica;

namespace UtilizandoOperadoresAritimeticos.CalculadoraAritimetica
{
    public class Program
    {
        static void Main(string[] args)
        {
           Calculadora calculator = new Calculadora();

            calculator.Somar(77, 264);
            calculator.Subtrair(1910, 543);
            calculator.Multiplicar(12, 34);
            calculator.Dividir(36, 4);
            calculator.Potencia(7, 8);
            calculator.Seno(60);
            calculator.Coseno(45);
            calculator.Tangente(90);
            calculator.RaizQuadrada(144);
        }
    }
}
