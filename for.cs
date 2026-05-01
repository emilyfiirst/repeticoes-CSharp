using System;

namespace ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("** EXERCÍCIOS DE ESTRUTURAS FOR **\n");
                Console.WriteLine("1 - Números de 1 a 20");
                Console.WriteLine("2 - Contagem regressiva para foguete");
                Console.WriteLine("3 - Números pares entre 1 e 50");
                Console.WriteLine("4 - Tabuada de um número");
                Console.WriteLine("5 - Soma de 1 a 100");
                Console.WriteLine("6 - Média de 5 alunos");
                Console.WriteLine("7 - Maior e menor de 5 números");
                Console.WriteLine("8 - Quadrado de asteriscos");
                Console.WriteLine("9 - Triângulo retângulo");
                Console.WriteLine("10 -Todas as tabuadas (1 a 10)");
                Console.WriteLine("0.  Sair");
                Console.Write("Escolha um exercício: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        Exercicio2();
                        break;
                    case "3":
                        Exercicio3();
                        break;
                    case "4":
                        Exercicio4();
                        break;
                    case "5":
                        Exercicio5();
                        break;
                    case "6":
                        Exercicio6();
                        break;
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "9":
                        Exercicio9();
                        break;
                    case "10":
                        Exercicio10();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar && opcao != "0")
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // Exercício 1: Números de 1 a 20
        static void Exercicio1()
        {
            Console.WriteLine("** EXERCÍCIO 1: Números de 1 a 20 **\n");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Exercício 2: Contagem regressiva para foguete
        static void Exercicio2()
        {
            Console.WriteLine("** EXERCÍCIO 2: Contagem Regressiva **\n");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fogo!");
        }

        // Exercício 3: Números pares entre 1 e 50
        static void Exercicio3()
        {
            Console.WriteLine("** EXERCÍCIO 3: Números Pares (1 a 50) **\n");

            for (int i = 2; i <= 50; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Exercício 4: Tabuada de um número
        static void Exercicio4()
        {
            Console.WriteLine("** EXERCÍCIO 4: Tabuada **\n");

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // Exercício 5: Soma de 1 a 100
        static void Exercicio5()
        {
            Console.WriteLine("** EXERCÍCIO 5: Soma de 1 a 100 **\n");

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma de todos os números de 1 a 100 é: {soma}");
        }

        // Exercício 6: Média de 5 alunos
        static void Exercicio6()
        {
            Console.WriteLine("** EXERCÍCIO 6: Média de 5 Alunos **\n");

            double somaNotas = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite a nota do aluno {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somaNotas += nota;
            }

            double media = somaNotas / 5;
            Console.WriteLine($"\nA média geral da turma é: {media:F2}");
        }

        // Exercício 7: Maior e menor de 5 números
        static void Exercicio7()
        {
            Console.WriteLine("** EXERCÍCIO 7: Maior e Menor Número **\n");

            int maior = -999999;
            int menor = 999999;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine($"O maior número digitado foi: {maior}");
            Console.WriteLine($"O menor número digitado foi: {menor}");
        }

        // Exercício 8: Quadrado de asteriscos
        static void Exercicio8()
        {
            Console.WriteLine("** EXERCÍCIO 8: Quadrado de Asteriscos **\n");

            Console.Write("Digite o tamanho do quadrado: ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= tamanho; i++)
            {
                for (int j = 1; j <= tamanho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Exercício 9: Triângulo retângulo
        static void Exercicio9()
        {
            Console.WriteLine("*** EXERCÍCIO 9: Triângulo Retângulo **\n");

            Console.Write("Digite o tamanho do triângulo: ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= tamanho; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Exercício 10: Todas as tabuadas de 1 a 10
        static void Exercicio10()
        {
            Console.WriteLine("** EXERCÍCIO 10: Todas as Tabuadas (1 a 10) **\n");

            for (int numero = 1; numero <= 10; numero++)
            {
                Console.WriteLine($"Tabuada do {numero}:");

                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
                }

                Console.WriteLine(); // Linha em branco entre tabuadas
            }
        }
      
    }
}
