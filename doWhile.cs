using System;

namespace AtividadesDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("** ATIVIDADES - LAÇOS DO-WHILE **");
                Console.WriteLine();
                Console.WriteLine("1. Sistema de Compras (ItemA e ItemB)");
                Console.WriteLine("2. Leitura de Números Positivos (Média)");
                Console.WriteLine("3. Números entre 100 e 200");
                Console.WriteLine("4. DESAFIO - Máquina de Vendas Automática");
                Console.WriteLine("0. Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Desafio();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }

        static void Exercicio1()
        {
            int qtdItemA = 0, qtdItemB = 0;
            decimal precoItemA = 50.00m;
            decimal precoItemB = 30.00m;
            int opcaoMenu;

            do
            {
                Console.Clear();
                Console.WriteLine("** SISTEMA DE COMPRAS **");
                Console.WriteLine();
                Console.WriteLine("1. Comprar");
                Console.WriteLine("2. Resumo da Compra");
                Console.WriteLine("3. Encerrar");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1: // Comprar
                        Console.Clear();
                        Console.WriteLine("** PRODUTOS DISPONÍVEIS **");
                        Console.WriteLine($"1. Item A - R$ {precoItemA:F2}");
                        Console.WriteLine($"2. Item B - R$ {precoItemB:F2}");
                        Console.WriteLine();
                        Console.Write("Escolha o produto (1 ou 2): ");

                        int produtoEscolhido = int.Parse(Console.ReadLine());

                        if (produtoEscolhido == 1)
                        {
                            qtdItemA++;
                            Console.WriteLine($"\nItem A adicionado ao carrinho! (R$ {precoItemA:F2})");
                        }
                        else if (produtoEscolhido == 2)
                        {
                            qtdItemB++;
                            Console.WriteLine($"\nItem B adicionado ao carrinho! (R$ {precoItemB:F2})");
                        }
                        else
                        {
                            Console.WriteLine("\nProduto inválido!");
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2: // Resumo da Compra
                        Console.Clear();
                        Console.WriteLine("** RESUMO DA COMPRA **");
                        Console.WriteLine();

                        decimal totalItemA = qtdItemA * precoItemA;
                        decimal totalItemB = qtdItemB * precoItemB;
                        int totalItens = qtdItemA + qtdItemB;
                        decimal totalGeral = totalItemA + totalItemB;

                        Console.WriteLine($"Item A: {qtdItemA} unidade(s) x R$ {precoItemA:F2} = R$ {totalItemA:F2}");
                        Console.WriteLine($"Item B: {qtdItemB} unidade(s) x R$ {precoItemB:F2} = R$ {totalItemB:F2}");
                        Console.WriteLine();
                        Console.WriteLine($"Total de itens: {totalItens}");
                        Console.WriteLine($"Total a pagar: R$ {totalGeral:F2}");

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3: // Encerrar
                        Console.Clear();
                        Console.WriteLine("** COMPRA ENCERRADA **");
                        Console.WriteLine();

                        int totalItensEncerrar = qtdItemA + qtdItemB;
                        decimal totalPagarEncerrar = (qtdItemA * precoItemA) + (qtdItemB * precoItemB);

                        Console.WriteLine($"Total de itens comprados: {totalItensEncerrar}");
                        Console.WriteLine($"Total a pagar: R$ {totalPagarEncerrar:F2}");
                        Console.WriteLine();
                        Console.WriteLine("Obrigado pela preferência!");

                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

            } while (opcaoMenu != 3);
        }

        static void Exercicio2()
        {
            Console.WriteLine("** LEITURA DE NÚMEROS POSITIVOS **");
            Console.WriteLine();
            Console.WriteLine("Digite números positivos (número negativo encerra):");
            Console.WriteLine();

            int quantidade = 0;
            double soma = 0;
            double numero;

            do
            {
                Console.Write($"Número {quantidade + 1}: ");
                numero = double.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    soma += numero;
                    quantidade++;
                }

            } while (numero >= 0);

            Console.WriteLine();
            Console.WriteLine($"Quantidade de números digitados: {quantidade}");

            if (quantidade > 0)
            {
                double media = soma / quantidade;
                Console.WriteLine($"Média dos números: {media:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum número positivo foi digitado.");
            }
        }

        static void Exercicio3()
        {
            Console.WriteLine("** NÚMEROS ENTRE 100 E 200 **");
            Console.WriteLine();
            Console.WriteLine("Digite números (0 encerra o programa):");
            Console.WriteLine();

            int contador = 0;
            int numero;

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 100 && numero <= 200)
                {
                    contador++;
                }

            } while (numero != 0);

            Console.WriteLine();
            Console.WriteLine($"Quantidade de números entre 100 e 200: {contador}");
        }



        static void Desafio()
        {
            string continuar = "-";

            do
            {
                Console.Clear();
                Console.WriteLine("** MÁQUINA AUTOMÁTICA DE VENDAS **");
                Console.WriteLine();
                Console.WriteLine("MENU DE PRODUTOS:");
                Console.WriteLine("1. Chocolate - R$ 3,00");
                Console.WriteLine("2. Refrigerante - R$ 4,00");
                Console.WriteLine("3. Sanduíche - R$ 7,00");
                Console.WriteLine("4. Cerveja - R$ 6,00");
                Console.WriteLine("5. Fruta - R$ 1,00");
                Console.WriteLine("6. Água - R$ 2,00");
                Console.WriteLine();
                Console.Write("Escolha o produto (1-6): ");
                int escolha = int.Parse(Console.ReadLine());

                // Variáveis para armazenar o produto selecionado
                string nomeProduto = "";
                decimal valorProduto = 0;

                // Definir produto e preço baseado na escolha usando switch-case
                switch (escolha)
                {
                    case 1:
                        nomeProduto = "Chocolate";
                        valorProduto = 3.00m;
                        break;
                    case 2:
                        nomeProduto = "Refrigerante";
                        valorProduto = 4.00m;
                        break;
                    case 3:
                        nomeProduto = "Sanduíche";
                        valorProduto = 7.00m;
                        break;
                    case 4:
                        nomeProduto = "Cerveja";
                        valorProduto = 6.00m;
                        break;
                    case 5:
                        nomeProduto = "Fruta";
                        valorProduto = 1.00m;
                        break;
                    case 6:
                        nomeProduto = "Água";
                        valorProduto = 2.00m;
                        break;
                    default:
                        Console.WriteLine("\nProduto inválido!");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

                Console.WriteLine();
                Console.WriteLine($"Produto selecionado: {nomeProduto} - R$ {valorProduto:F2}");
                Console.WriteLine();
                Console.WriteLine("Cédulas aceitas: R$ 2, R$ 5, R$ 10, R$ 20, R$ 50");
                Console.WriteLine("Insira as cédulas (digite o valor da nota):");
                Console.WriteLine();

                decimal totalInserido = 0;
                int cedula;

                do
                {
                    Console.Write($"Faltam R$ {(valorProduto - totalInserido):F2} - Insira cédula: R$ ");
                    cedula = int.Parse(Console.ReadLine());

                    if (cedula == 2 || cedula == 5 || cedula == 10 || cedula == 20 || cedula == 50)
                    {
                        totalInserido += cedula;
                        Console.WriteLine($"R$ {cedula},00 aceito. Total: R$ {totalInserido:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Cédula não aceita! Use apenas: 2, 5, 10, 20 ou 50");
                    }

                } while (totalInserido < valorProduto);

                // Calcular troco
                decimal troco = totalInserido - valorProduto;

                Console.WriteLine();
                Console.WriteLine($"Valor do produto: R$ {valorProduto:F2}");
                Console.WriteLine($"Valor inserido:   R$ {totalInserido:F2}");
                Console.WriteLine($"Troco:            R$ {troco:F2}");
                Console.WriteLine();

                if (troco > 0)
                {
                    Console.WriteLine("TROCO:");

                    int trocoInteiro = (int)troco;

                    // Cédulas de 50
                    int qtd50 = trocoInteiro / 50;
                    trocoInteiro = trocoInteiro % 50;
                    if (qtd50 > 0)
                    {
                        Console.WriteLine($"{qtd50} cédula(s) de R$ 50");
                    }

                    // Cédulas de 20
                    int qtd20 = trocoInteiro / 20;
                    trocoInteiro = trocoInteiro % 20;
                    if (qtd20 > 0)
                    {
                        Console.WriteLine($"{qtd20} cédula(s) de R$ 20");
                    }

                    // Cédulas de 10
                    int qtd10 = trocoInteiro / 10;
                    trocoInteiro = trocoInteiro % 10;
                    if (qtd10 > 0)
                    {
                        Console.WriteLine($"{qtd10} cédula(s) de R$ 10");
                    }

                    // Cédulas de 5
                    int qtd5 = trocoInteiro / 5;
                    trocoInteiro = trocoInteiro % 5;
                    if (qtd5 > 0)
                    {
                        Console.WriteLine($"{qtd5} cédula(s) de R$ 5");
                    }

                    // Cédulas de 2
                    int qtd2 = trocoInteiro / 2;
                    trocoInteiro = trocoInteiro % 2;
                    if (qtd2 > 0)
                    {
                        Console.WriteLine($"{qtd2} cédula(s) de R$ 2");
                    }

                    // Moedas de 1
                    int qtdMoedas = trocoInteiro;
                    if (qtdMoedas > 0)
                    {
                        Console.WriteLine($"{qtdMoedas} moeda(s) de R$ 1");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Produto '{nomeProduto}' liberado!");
                Console.WriteLine("Obrigado pela preferência!");
                Console.WriteLine();

                Console.Write("Deseja comprar outro produto? (S/N): ");
                continuar = Console.ReadLine().ToUpper();
                Console.WriteLine();

            } while (continuar == "S");

            Console.WriteLine("\nEncerrando máquina de vendas...");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
