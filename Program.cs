using System;
using System.Reflection;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExercicioSeis();
            
            ExercicioUm();
            ExercicioDois();
            ExercicioTres();
            ExercicioQuatro();
            ExercicioCinco();
            ExercicioSeis();
            ExercicioSete();
            SquareRoot();
            NumberModule();
            QuadraticEquationPos();
            QuadraticEquationNeg();
            Factorial();

            Console.ReadLine();
        }

        static void ExercicioUm()
        {
            Console.Write("Indique um número para A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique um número para B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique um número para C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique um número para D: ");
            int D = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[] { A, B, C, D };


            Array.Sort(numbers);
            Console.WriteLine("O menor número é: " + numbers[0]);

            Console.ReadKey();
            Console.Clear();
        }
            

        static void ExercicioDois()
        {
            int resultadoUm, resultadoDois;

            Console.Write("Indique um número: ");
            int um = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique outro número: ");
            int dois = Convert.ToInt32(Console.ReadLine());

            resultadoUm = um / dois;
            resultadoDois = dois / um;

            if (resultadoUm < resultadoDois)
                Console.WriteLine("O número {0} a dividir pelo número {1}, dá um resultado com o valor {2}, que é o maior.", dois, um, resultadoDois);
            else
                Console.WriteLine("O número {0} a dividir pelo número {1}, dá um resultado com o valor {2}, que é o maior.", um, dois, resultadoUm);

            Console.ReadKey();
            Console.Clear();
        }

        static void ExercicioTres()
        {
            double primeiroNum;
            double segundoNum;
            double terceiroNum;
            double quartoNum;

            Console.Write("Induza um primeiro valor: ");
            primeiroNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduza um segundo valor: ");
            segundoNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduza um terceiro valor: ");
            terceiroNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduza um quarto valor: ");
            quartoNum = Convert.ToDouble(Console.ReadLine());

            double resultado3 = primeiroNum / segundoNum + terceiroNum + quartoNum;
            resultado3 = Convert.ToDouble(resultado3);

            double resultado4 = segundoNum / primeiroNum + terceiroNum + quartoNum;
            resultado4 = Convert.ToDouble(resultado4);

            double resultado5 = terceiroNum / primeiroNum + segundoNum + quartoNum;
            resultado5 = Convert.ToDouble(resultado5);

            double resultado6 = quartoNum / primeiroNum + segundoNum + terceiroNum;
            resultado6 = Convert.ToDouble(resultado6);


            if (resultado3 < resultado4 && resultado3 < resultado5 && resultado3 < resultado6)
            {
                Console.WriteLine("Após a divisão do valor {0} com a soma dos restantes valores {1}, {2} e {3} resulta o valor {4} sendo identificado como o menor resultado.", primeiroNum, segundoNum, terceiroNum, quartoNum, resultado3);
            }
            if (resultado4 < resultado3 && resultado4 < resultado5 && resultado4 < resultado6)
            {
                Console.WriteLine("Após a divisão do valor {0} com a soma dos restantes valores {1}, {2} e {3} resulta o valor {4} sendo identificado como o menor resultado.", segundoNum, primeiroNum, terceiroNum, quartoNum, resultado4);
            }
            if (resultado5 < resultado3 && resultado5 < resultado4 && resultado5 < resultado6)
            {
                Console.WriteLine("Após a divisão do valor {0} com a soma dos restantes valores {1}, {2} e {3} resulta o valor {4} sendo identificado como o menor resultado.", terceiroNum, primeiroNum, segundoNum, quartoNum, resultado5);
            }
            if (resultado6 < resultado3 && resultado6 < resultado4 && resultado6 < resultado5)
            {
                Console.WriteLine("O valor indentificado como menor é {0}, após a divisão do valor atribuido a {1} com a soma dos restantes valores {2}, {3} e {4}", resultado6, quartoNum, primeiroNum, segundoNum, terceiroNum);
            }

            Console.ReadKey();
            Console.Clear();

        }

        static void ExercicioQuatro()
        {

            decimal z;
            decimal y;   // ou float x = 2.3454;

            Console.Write("Introduza um valor para Z: ");
            z = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Introduza um valor para Y: ");
            y = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("O valor de Z dividindo por Y é: {0}", decimal.Round((z / y), 2));

            Console.ReadKey();
            Console.Clear();
        }

        static void ExercicioCinco()
        {
            int E;
            int F;

            Console.Write("Introduza um número para E: ");
            E = Convert.ToInt32(Console.ReadLine()); // ou E = int.Parse(Console.ReadLine());

            Console.Write("Introduza um número para F: ");
            F = Convert.ToInt32(Console.ReadLine()); // ou F = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da multiplicação entre o número atribuido a E: {0} e o número atribuido a F: {1} é de {2}", E, F, (E * F));
            int resultado = E * F;

            if (resultado % 2 == 0)
                Console.WriteLine("Bizz");
            else
                Console.WriteLine("Buzz");

            Console.ReadKey();
            Console.Clear();
        }

        static void ExercicioSeis()
        {
            int exercicio;
            int counter = 10;

            do
            {
                Console.WriteLine("Escreve o numero correspondente ao exercicio que pretendes executar: ");
                Console.WriteLine("1 - Identificar 4 números e o resultado apresentado será o maior entre eles.");
                Console.WriteLine("2 - Identificar 2 números e o resultado apresentado será o maior valor da divisão entre eles.");
                Console.WriteLine("3 - Identificar 4 números e o resultado apresentado será o menor valor da divisão com a soma entre eles.");
                Console.WriteLine("4 - Identificar 2 números e o resultado apresentado será o valor da divisão com duas casas décimais.");
                Console.WriteLine("5 - Identificar 2 números e o resultado apresentado será conforme o valor da sua multiplicação.");
                Console.WriteLine("6 - Calculadora.");
                Console.WriteLine("0 - Sair.");
                Console.WriteLine("Número de oportunidades: " + counter);

                
                exercicio = Convert.ToInt32(Console.ReadLine());
                counter--;
                
                
                Console.Clear();

                if (exercicio > 6 || exercicio < 0)
                {
                    Console.WriteLine("A opção " + exercicio + " não é válida");
                    Console.WriteLine("Por favor insira uma opção válida");
                    Console.WriteLine();
                }
                if (exercicio == 1)
                    ExercicioUm();
            
                if (exercicio == 2)
                    ExercicioDois();
                
                if (exercicio == 3)
                    ExercicioTres();
               
                if (exercicio == 4)
                    ExercicioQuatro();
              
                if (exercicio == 5)
                    ExercicioCinco();
               
                if (exercicio == 6)
                    ExercicioSete();
               
                if (exercicio == 0)
                    break;

            } while ((exercicio < 6 || exercicio >=1) & counter < 11);


                Console.ReadKey();
                Console.Clear();
            }

        static void ExercicioSete()
        {
            double number1, number2, result = 0;
            string operador;

            Console.WriteLine("Introduz o primeiro número: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduz o sinal da operação a realizar: ");
            operador = Console.ReadLine();

            Console.WriteLine("Introduz o segundo número: ");
            number2 = Convert.ToDouble(Console.ReadLine());


            switch (operador)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.WriteLine("{0}{1}{2} = {3}", number1, operador, number2, result);

            Console.ReadKey();
            Console.Clear();
        }

        static void SquareRoot()
        {
            double x;


            Console.WriteLine("Indique um número: ");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("O valor da raiz quadrada é: {0}", Math.Round(Math.Sqrt(x), 2));

            Console.ReadKey();
            Console.Clear();
        }

        static void NumberModule()
        {
        double V;

        Console.WriteLine("Introduza um número: ");
            V = Convert.ToDouble(Console.ReadLine());

              
                Console.WriteLine("O Valor absoluto de {0} é {1}", V, Math.Abs(V));

            Console.ReadKey();
            Console.Clear();
        }

        static void QuadraticEquationPos()
        {
            int a, b, c;
            double d, x1, x2;

            Console.Write("Introduza um numero para a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza um numero para b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza um numero para c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d == 0)
            {
                x1 = -b / 2 * a;
                x2 = x1;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("O valor da raiz positivo é {0}", x1);
               
            }
            else
            {
                Console.WriteLine("Não há solução, as raizes não são válidas.");
            }

        }

        static void QuadraticEquationNeg()
        {
            int a, b, c;
            double d, x1, x2;

            Console.Write("Introduza um numero para a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza um numero para b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza um numero para c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d == 0)
            {
                x1 = -b / 2 * a;
                x2 = x1;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("O valor da raiz negativo é {0}", x2);

            }
            else
            {
                Console.WriteLine("Não há solução, as raizes não são válidas.");
            }

        }

        static void Factorial()
        {
            int i, fatorial, numero;
            Console.WriteLine("Introduza um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            fatorial = numero;

            for (i = numero - 1; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("O valor fatorial do número {0} é {1}.", numero, fatorial);
        }
    }
    
}
