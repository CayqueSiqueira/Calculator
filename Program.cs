// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Reflection;

namespace MyApp
{
    internal class Program
    {
        // Lista para armazenar o histórico
        static List<string> historico = new List<string>();
        
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1  - Soma             8  - Porcentagem");
            Console.WriteLine("2  - Subtração        9  - Seno");
            Console.WriteLine("3  - Multiplicação   10  - Coseno");
            Console.WriteLine("4  - Divisão         11  - Tangente");
            Console.WriteLine("5  - Raiz Quadrada   12  - Logaritmo");
            Console.WriteLine("6  - Potência        13  - Histórico de Cálculos");
            Console.WriteLine("7  - Fatorial         0  - Sair");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: RaizQuadrada(); break;
                case 6: Potencia(); break;
                case 7: Fatorial(); break;
                case 8: Porcentagem(); break;
                case 9: Seno(); break;
                case 10: Coseno(); break;
                case 11: Tangente(); break;
                case 12: Logaritimo(); break;
                case 13: Historico(); break;
                default: Menu(); break;
            }
        }


        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = valor1 + valor2;

            string registro = $"{valor1} + {valor2} = {resultado}";
            historico.Add(registro);


            Console.WriteLine($"O resultado da adição é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1-v2;

            string registro = $"{v1} - {v2} = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;

            string registro = $"{v1} * {v2} = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (v2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            else
            {
                float resultado = v1 / v2;
                string registro = $"{v1} / {v2} = {resultado}";
                historico.Add(registro);
                Console.WriteLine($"O resultado da divisão é {resultado}");
            }

            Console.ReadKey();
            Menu();
        }
    
        static void RaizQuadrada(){
            Console.Clear();
            Console.WriteLine("Digite o número para calcular a raiz quadrada: ");
            double v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = Math.Sqrt(v1);
            string registro = $"√{v1} = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O resultado da raiz quadrada é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Potencia(){
            Console.Clear();
            Console.WriteLine("Primeiro Valor(base): ");
            double baseValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor(expoente): ");
            double expoente = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Pow(baseValor, expoente);
            string registro = $"{baseValor} ^ {expoente} = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O resultado da potencia é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Fatorial()
        {
            Console.Clear();
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine());
            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            string registro = $"{numero}! = {resultado}";
            historico.Add(registro);
            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Porcentagem(){
            Console.Clear();
            Console.WriteLine("Valor do total: ");
            double total = double.Parse(Console.ReadLine());
            Console.WriteLine("Percetagem desejada: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = (total * porcentagem) / 100;

            string registro = $"{porcentagem}% de {total} = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"{porcentagem}% de {total} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Seno(){
            Console.Clear();
            Console.WriteLine("Digite o ângulo em graus:");
            double graus = double.Parse(Console.ReadLine());
            double radianos = graus * (Math.PI / 180);
            double resultado = Math.Sin(radianos);

            string registro = $"Seno({graus}°) = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O seno de {graus} graus é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Coseno(){
            Console.Clear();
            Console.WriteLine("Digite o ângulo em graus:");
            double graus = double.Parse(Console.ReadLine());
            double radianos = graus * (Math.PI / 180);
            double resultado = Math.Cos(radianos);

            string registro = $"Coseno({graus}°) = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O cosseno de {graus} graus é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        
        static void Tangente(){
            Console.Clear();
            Console.WriteLine("Digite o ângulo em graus:");
            double graus = double.Parse(Console.ReadLine());
            double radianos = graus * (Math.PI / 180);
            double resultado = Math.Tan(radianos);

            string registro = $"Tangente({graus}°) = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"A tangente de {graus} graus é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        
        static void Logaritimo(){
            Console.Clear();
            Console.WriteLine("Digite o número para calcular o logaritmo (base 10):");
            double numero = double.Parse(Console.ReadLine());
            double resultado = Math.Log10(numero);

            string registro = $"Log(10, {numero}) = {resultado}";
            historico.Add(registro);

            Console.WriteLine($"O logaritmo base 10 de {numero} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Historico()
        {
            Console.Clear();
            if (historico.Count == 0)
            {
                Console.WriteLine("Nenhuma operação realizada até agora.");
            }
            else
            {
                Console.WriteLine("Histórico de Operações:");
                foreach (string registro in historico)
                {
                    Console.WriteLine(registro);
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

    }
}
