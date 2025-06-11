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
            Console.WriteLine("Escolha a operação: +, -, *, /, %, **, seno, cosseno, tangente");
            string operacao = Console.ReadLine();

            if (operacao == "seno" || operacao == "cosseno" || operacao == "tangente")
            {
                Console.WriteLine("Digite o ângulo em graus:");
                double angulo = Convert.ToDouble(Console.ReadLine());
                switch (operacao)
                {
                    case "seno":
                        calculator.Seno(angulo);
                        break;
                    case "cosseno":
                        calculator.Coseno(angulo);
                        break;
                    case "tangente":
                        calculator.Tangente(angulo);
                        break;
                    default:
                        Console.WriteLine("Operação inválida para ângulos.");
                        break;
                }
                return;
            }
            else if (operacao == "raiz quadrada")
            {
                Console.WriteLine("Digite o número para calcular a raiz quadrada:");
                double numero = Convert.ToDouble(Console.ReadLine());
                calculator.RaizQuadrada(numero);
                return;
            }
            else if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/" || operacao == "%" || operacao == "**")
            {
                Console.WriteLine("Digite o primeiro número:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                int n2 = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
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

                    default:
                        Console.WriteLine("Digite, por favor, uma operação válida.");
                        break;

                }
            }
        }
    }
}
