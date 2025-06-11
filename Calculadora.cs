using System;

namespace CalculadoraAritimetica
{
    public class Calculadora
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"{n1} X {n2} = {n1 * n2}");
        }
        public void Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        }
        public void Modular(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
        }
        public void Potencia(int n1, int n2)
        {
            if (n1 < 0 && n2 % 2 == 0)
            {
                Console.WriteLine("Potência de número negativo com expoente par não é permitida.");
                return;
            }

                double pot = Math.Pow(n1, n2);
            Console.WriteLine($"{n1} ^ {n2} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Raiz quadrada de número negativo não é permitida.");
                return;
            }
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"Raiz quadrada de {numero} = {Math.Round(raiz, 4)}");
        }
    }
}
