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

            Console.WriteLine("Calculadora Aritmética");
            Console.WriteLine("Digite o primeiro número:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha a operação: +, -, *, /, %, **, seno, cosseno, tangente");
            string operacao = Console.ReadLine();

            switch (operacao){
                case "+":
                    calculator.Somar(n1, n2);
                    break;
                case "-":
                    calculator.Subtrair(n1, n2);
                    break;
                case "*":
                    calculator.Multiplicar(n1, n2);
                    break;
                case "/":
                    calculator.Dividir(n1, n2);
                    break;
                case "%":
                    calculator.Modular(n1, n2);
                    break;
                case "**":
                    calculator.Potencia(n1, n2);
                    break;
                case "seno":
                    calculator.Seno(n1);
                    break;
                case "cosseno":
                    calculator.Coseno(n1);
                    break;
                case "tangente":
                    calculator.Tangente(n1);
                    break;
                default:
                    Console.WriteLine("Digite, por favor, uma operação válida.");
                    break; 


            }
        }
    }
}
