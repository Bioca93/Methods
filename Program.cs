using System;

namespace MethodsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            ImprimirMenu();

            Console.Write("Por favor, escolha o menu desejado: ");
            do
            {
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao < 1 || opcao > 3)
                {
                    Console.Clear();

                    ImprimirMenu();

                    Console.WriteLine("Opção inválida");
                    Console.Write("Por favor, escolha uma opção correta: ");
                }

            } while (opcao < 1 || opcao > 3);


            Calculadora.CalcularEstatico();

            Calculadora calculadora = new Calculadora();

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            double resultado2Num = calculadora.Calcular(x, y, Operacao.Subtracao);
            double resultado3Num = calculadora.Calcular(x, y, z, Operacao.Subtracao);
            
            Console.WriteLine(resultado2Num);
            Console.WriteLine(resultado3Num);
        }

        private static void ImprimirMenu()
        {
            Console.WriteLine("Menu do dia");
            Console.WriteLine("1 - Açorda");
            Console.WriteLine("2 - Grelhada Mista");
            Console.WriteLine("3 - Sopa de Grão");
        }
    }
}
