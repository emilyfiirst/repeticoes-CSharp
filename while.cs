using System;

namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** EXERCÍCIOS COM WHILE EM C# **\n");

            // Descomente o exercício que deseja executar
            // Exercicio1();
            // Exercicio2();
            // Exercicio3();
            // Exercicio4();
            // Exercicio5();
            // Exercicio6();
            // Exercicio7();
             Exercicio8();
        }

        static void Exercicio1()
        {
            Console.WriteLine("EXERCÍCIO 1: Contador Básico");
            Console.WriteLine("Imprimindo números de 1 a 10:\n");

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine();
        }

        static void Exercicio2()
        {
            Console.WriteLine("EXERCÍCIO 2: Números Pares");
            Console.Write("Digite um número N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nNúmeros pares de 0 até {n}:");
            int numero = 0;
            while (numero <= n)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            Console.WriteLine("\n");
        }

        static void Exercicio3()
        {
            Console.WriteLine("EXERCÍCIO 3: Soma de Números");
            Console.WriteLine("Digite números para somar (0 para parar):\n");

            int soma = 0;
            int numero = -1;

            while (numero != 0)
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            }

            Console.WriteLine($"\nSoma total: {soma}\n");
        }

        static void Exercicio4()
        {
            Console.WriteLine("EXERCÍCIO 4: Validação de Senha");

            string senhaCorreta = "senha123";
            string senhaDigitada = "";

            while (senhaDigitada != senhaCorreta)
            {
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if (senhaDigitada != senhaCorreta)
                {
                    Console.WriteLine("Senha incorreta! Tente novamente.\n");
                }
            }

            Console.WriteLine("Senha correta! Acesso liberado.\n");
        }

        static void Exercicio5()
        {
            Console.WriteLine("EXERCÍCIO 5: Tabuada");
            Console.Write("Digite um número para ver sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {numero}:");
            int multiplicador = 1;

            while (multiplicador <= 10)
            {
                int resultado = numero * multiplicador;
                Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
                multiplicador++;
            }
            Console.WriteLine();
        }


        static void Exercicio6()
        {
            Console.WriteLine("EXERCÍCIO 6: Contagem Regressiva");
            Console.Write("Digite um número para contagem regressiva: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nContagem regressiva:");
            while (numero >= 0)
            {
                Console.WriteLine(numero);
                numero--;
            }
            Console.WriteLine("FIM!\n");
        }

        static void Exercicio7()
        {
            Console.WriteLine("EXERCÍCIO 7: Fatorial");
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = 1;
          
            while (numero > 0)
            {
                resultado = resultado * numero;
                 numero--;
            }

            Console.WriteLine("Fatorial = " + resultado);
        }

        static void Exercicio8()
        {
            Console.WriteLine("EXERCÍCIO 8: Jogo de Adivinhar Número");
            Console.WriteLine("Adivinhe o número entre 1 e 100!\n");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 0;
            int tentativas = 0;

            while (tentativa != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O número é MAIOR! Tente novamente.\n");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("O número é MENOR! Tente novamente.\n");
                }
                else
                {
                    Console.WriteLine($"PARABÉNS! Você acertou o número {numeroSecreto}!");
                    Console.WriteLine($"Você precisou de {tentativas} tentativa(s).\n");
                }
            }
        }

        static void Exercicio9()
        {
            Console.WriteLine("EXERCÍCIO 10: Menu de Opções");

            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1 - Ver data atual");
                Console.WriteLine("2 - Ver hora atual");
                Console.WriteLine("3 - Ver dia da semana");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"\nData atual: {DateTime.Now.ToShortDateString()}");
                        break;
                    case 2:
                        Console.WriteLine($"\nHora atual: {DateTime.Now.ToShortTimeString()}");
                        break;
                    case 3:
                        Console.WriteLine($"\nDia da semana: {DateTime.Now.DayOfWeek}");
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa... Até logo!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
