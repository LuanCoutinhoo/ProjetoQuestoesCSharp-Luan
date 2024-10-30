using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace QuestoesCSharp
{
    // Classe Produto
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }





    class Program
    {
        static void Main(string[] args)
        {
            int menuOpcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("Trabalho feito apenas 77% da questões!");
                Console.WriteLine("1 - Acessar Menu de Questões");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                menuOpcao = Convert.ToInt32(Console.ReadLine());

                switch (menuOpcao)
                {
                    case 1:
                        ExibirMenuQuestoes();
                        break;
                    case 0:
                        Console.WriteLine("Sair...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;
                }

            } while (menuOpcao != 0);
        }
        static void ExibirMenuQuestoes()
        {


            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu de Questões:");
                Console.WriteLine("1 - Criar Produto e exibir valores");
                Console.WriteLine("3 - Somar dois números inteiros");
                Console.WriteLine("4 - Verificar se um número é par ou ímpar");
                Console.WriteLine("5 - Converter metros para centímetros");
                Console.WriteLine("6 - Verificar se é maior de idade");
                Console.WriteLine("7 - Calcular a área de um círculo");
                Console.WriteLine("8 - Exibir tabuada de um número");
                Console.WriteLine("9 - Somar números de 1 a N");
                Console.WriteLine("10 - Converter Celsius para Fahrenheit");
                Console.WriteLine("11 - Verificar se uma string é nula ou vazia");
                Console.WriteLine("12 - Exibir todos os números pares entre 1 e 50");
                Console.WriteLine("13 - Retornar o maior de três números");
                Console.WriteLine("14 - Inverter uma string");
                Console.WriteLine("15 - Verificar se pode votar (ano de nascimento)");
                Console.WriteLine("16 - Verificar se um número é positivo ou negativo");
                Console.WriteLine("17 - Calcular a média de três notas");
                Console.WriteLine("18 - Contar letras 'a' em uma string");
                Console.WriteLine("19 - Imprimir números de 1 a 10 em ordem decrescente");
                Console.WriteLine("20 - Calcular soma dos quadrados de 1 a N");
                Console.WriteLine("21 - Exibir boas-vindas com nome e idade");
                Console.WriteLine("22 - Exibir o dobro e o triplo de um número");
                Console.WriteLine("23 - Retornar o último caractere de uma string");
                Console.WriteLine("24 - Converter horas em segundos");
                Console.WriteLine("25 - Verificar se um número é divisível por 3 e 5");
                Console.WriteLine("26 - Ordenar três números");
                Console.WriteLine("28 - Exibir Nome e Nota do Aluno");
                Console.WriteLine("29 - Calcular média de uma lista de números");
                Console.WriteLine("30 - Verificar se uma palavra é um palíndromo");
                Console.WriteLine("31 - Encontrar o menor número em um array");
                Console.WriteLine("32 - Multiplicar elementos de um array por um valor");
                Console.WriteLine("33 - Somar números ímpares em um array");
                Console.WriteLine("34 - Criar e exibir informações de carros");
                Console.WriteLine("36 - Exibir os 10 primeiros números da sequência de Fibonacci");
                Console.WriteLine("37 - Substituir espaços em uma string por '_'");
                Console.WriteLine("38 - Retornar o índice do maior elemento de um array");
                Console.WriteLine("39 - Calcular o MDC (Máximo Divisor Comum)");
                Console.WriteLine("40 - Contar vogais em uma string");
                Console.WriteLine("41 - Converter decimal para binário");
                Console.WriteLine("44 - Calcular IMC");
                Console.WriteLine("45 - Encontrar o segundo maior número em um array");
                Console.WriteLine("46 - Inverter elementos de um array");
                Console.WriteLine("48 - Exibir dia da semana");
                Console.WriteLine("49 - Verificar se uma string contém apenas letras e números");
                Console.WriteLine("50 - Calcular potência sem usar Math.Pow()");
                Console.WriteLine("51 - Verificar se uma matriz é simétrica");
                Console.WriteLine("52 - Nomes em ordem alfabetica");
                Console.WriteLine("53 - Encontrar elemento mais frequente em um array");
                Console.WriteLine("54 - Calcular valor absoluto sem Math.Abs()");
                Console.WriteLine("55 - Implementar busca linear");
                Console.WriteLine("56 - Simular cronômetro simples");
                Console.WriteLine("57 - Contar número de palavras em uma string");
                Console.WriteLine("58 - Criar classe Pessoa com método Falar()");
                Console.WriteLine("59 - Interseção entre dois arrays");
                Console.WriteLine("60 - Converter string para maiúsculas e minúsculas alternadas");
                Console.WriteLine("61 - Função que retorna o número de caracteres únicos em uma string");
                Console.WriteLine("62 - Numeros primos");
                Console.WriteLine("64 - Exibir os divisores de um numero");
                Console.WriteLine("65 - Calcular transposta de uma matriz");
                Console.WriteLine("66 - Exibir horário atual continuamente");
                Console.WriteLine("68 - Converter valor monetário para extenso");
                Console.WriteLine("70 - Simular caixa eletrônico para saques");
                Console.WriteLine("71 - Arrays sao iguais");
                Console.WriteLine("72 - Senha aleatoria");
                Console.WriteLine("73 - Gerar tabela de multiplicação");
                Console.WriteLine("74 - Calcula a área de um triângulo com base em três lados");
                Console.WriteLine("77 - Verificar dois arrays");
                Console.WriteLine("80 - Soma dos Dígitos de um Número");
                Console.WriteLine("81 - Números Pares");
                Console.WriteLine("83 - Ordenação de Nomes");
                Console.WriteLine("89 - Média e Aprovação de Aluno");
                Console.WriteLine("90 - Soma de Elementos de uma Matriz");
                Console.WriteLine("92 - Múltiplos de 3 e 7");
                Console.WriteLine("96 - Exibir Números Primos entre 1 e 100");
                Console.WriteLine("97 - Tabuada de Multiplicação até 10");
                Console.WriteLine("99 - Soma dos Quadrados dos Números de 1 a N");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ExibirQuestao(Questao1);
                        break;
                    case 3:
                        ExibirQuestao(Questao3);
                        break;
                    case 4:
                        ExibirQuestao(Questao4);
                        break;
                    case 5:
                        ExibirQuestao(Questao5);
                        break;
                    case 6:
                        ExibirQuestao(Questao6);
                        break;
                    case 7:
                        ExibirQuestao(Questao7);
                        break;
                    case 8:
                        ExibirQuestao(Questao8);
                        break;
                    case 9:
                        ExibirQuestao(Questao9);
                        break;
                    case 10:
                        ExibirQuestao(Questao10);
                        break;
                    case 11:
                        ExibirQuestao(Questao11);
                        break;
                    case 12:
                        ExibirQuestao(Questao12);
                        break;
                    case 13:
                        ExibirQuestao(Questao13);
                        break;
                    case 14:
                        ExibirQuestao(Questao14);
                        break;
                    case 15:
                        ExibirQuestao(Questao15);
                        break;
                    case 16:
                        ExibirQuestao(Questao16);
                        break;
                    case 17:
                        ExibirQuestao(Questao17);
                        break;
                    case 18:
                        ExibirQuestao(Questao18);
                        break;
                    case 19:
                        ExibirQuestao(Questao19);
                        break;
                    case 20:
                        ExibirQuestao(Questao20);
                        break;
                    case 21:
                        ExibirQuestao(Questao21);
                        break;
                    case 22:
                        ExibirQuestao(Questao22);
                        break;
                    case 23:
                        ExibirQuestao(Questao23);
                        break;
                    case 24:
                        ExibirQuestao(Questao24);
                        break;
                    case 25:
                        ExibirQuestao(Questao25);
                        break;
                    case 26:
                        ExibirQuestao(Questao26);
                        break;
                    case 27:
                        ExibirQuestao(Questao27);
                        break;
                    case 28:
                        ExibirQuestao(Questao28);
                        break;
                    case 29:
                        ExibirQuestao(Questao29);
                        break;
                    case 30:
                        ExibirQuestao(Questao30);
                        break;
                    case 31:
                        ExibirQuestao(Questao31);
                        break;
                    case 32:
                        ExibirQuestao(Questao32);
                        break;
                    case 33:
                        ExibirQuestao(Questao33);
                        break;
                    case 34:
                        ExibirQuestao(Questao34);
                        break;
                    case 36:
                        ExibirQuestao(Questao36);
                        break;
                    case 37:
                        ExibirQuestao(Questao37);
                        break;
                    case 38:
                        ExibirQuestao(Questao38);
                        break;
                    case 39:
                        ExibirQuestao(Questao39);
                        break;
                    case 40:
                        ExibirQuestao(Questao40);
                        break;
                    case 41:
                        ExibirQuestao(Questao41);
                        break;
                    case 42:
                        ExibirQuestao(Questao42);
                        break;
                    case 43:
                        ExibirQuestao(Questao43);
                        break;
                    case 44:
                        ExibirQuestao(Questao44);
                        break;
                    case 45:
                        ExibirQuestao(Questao45);
                        break;
                    case 46:
                        ExibirQuestao(Questao46);
                        break;
                    case 48:
                        ExibirQuestao(Questao48);
                        break;
                    case 49:
                        ExibirQuestao(Questao49);
                        break;
                    case 50:
                        ExibirQuestao(Questao50);
                        break;
                    case 51:
                        ExibirQuestao(Questao51);
                        break;
                    case 52:
                        ExibirQuestao(Questao52);
                        break;
                    case 53:
                        ExibirQuestao(Questao53);
                        break;
                    case 54:
                        ExibirQuestao(Questao54);
                        break;
                    case 55:
                        ExibirQuestao(Questao55);
                        break;
                    case 56:
                        ExibirQuestao(Questao56);
                        break;
                    case 57:
                        ExibirQuestao(Questao57);
                        break;
                    case 58:
                        ExibirQuestao(Questao58);
                        break;
                    case 59:
                        ExibirQuestao(Questao59);
                        break;
                    case 60:
                        ExibirQuestao(Questao60);
                        break;
                    case 61:
                        ExibirQuestao(Questao61);
                        break;
                    case 62:
                        ExibirQuestao(Questao62);
                        break;
                    case 64:
                        ExibirQuestao(Questao64);
                        break;
                    case 65:
                        ExibirQuestao(Questao65);
                        break;
                    case 66:
                        ExibirQuestao(Questao66);
                        break;
                    case 68:
                        ExibirQuestao(Questao68);
                        break;
                    case 70:
                        ExibirQuestao(Questao70);
                        break;
                    case 71:
                        ExibirQuestao(Questao71);
                        break;
                    case 72:
                        ExibirQuestao(Questao72);
                        break;
                    case 73:
                        ExibirQuestao(Questao73);
                        break;
                    case 74:
                        ExibirQuestao(Questao74);
                        break;
                    case 77:
                        ExibirQuestao(Questao77);
                        break;
                    case 80:
                        ExibirQuestao(Questao80);
                        break;
                    case 81:
                        ExibirQuestao(Questao81);
                        break;
                    case 83:
                        ExibirQuestao(Questao83);
                        break;
                    case 89:
                        ExibirQuestao(Questao89);
                        break;
                    case 92:
                        ExibirQuestao(Questao92);
                        break;
                    case 96:
                        ExibirQuestao(Questao96);
                        break;
                    case 97:
                        ExibirQuestao(Questao97);
                        break;
                    case 99:
                        ExibirQuestao(Questao99);
                        break;
                    case 0:
                        Console.WriteLine("Sair...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                if (opcao != 0)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 0);

        }

        // Método para exibir uma questão e voltar ao menu
        static void ExibirQuestao(Action questao)
        {
            Console.Clear();
            questao();
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey();
        }

        static void Questao1()
        {
            Produto produto = new Produto { Nome = "Teclado", Preco = 50.90 };
            Console.WriteLine($"Produto: {produto.Nome}, Preço: R$ {produto.Preco}");
        }

        static void Questao3()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine($"A soma de {a} e {b} é: {soma}");
        }

        static void Questao4()
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é par.");
            }
            else
            {
                Console.WriteLine($"{num} é ímpar.");
            }
        }

        static void Questao5()
        {
            Console.WriteLine("Digite o valor em metros: ");
            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100;
            Console.WriteLine($"{metros} metros é igual a {centimetros} centímetros.");
        }

        static void Questao6()
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }

        static void Questao7()
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do círculo é: {area}");
        }

        static void Questao8()
        {
            Console.WriteLine("Digite um número para exibir sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        static void Questao9()
        {
            Console.WriteLine("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos números de 1 até {N} é: {soma}");
        }

        static void Questao10()
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");
        }

        static void Questao11()
        {
            Console.WriteLine("Digite uma string: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("A string é nula ou vazia.");
            }
            else
            {
                Console.WriteLine("A string não é nula nem vazia.");
            }
        }

        static void Questao12()
        {
            Console.WriteLine("Números pares entre 1 e 50:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Questao13()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"O maior número é: {maior}");
        }


        static void Questao14()
        {
            Console.WriteLine("Digite uma string para inverter: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine($"String invertida: {new string(arr)}");
        }


        static void Questao15()
        {
            Console.WriteLine("Digite o ano de nascimento: (dia.mês.ano)");
            int ano = int.Parse(Console.ReadLine());
            int idade = DateTime.Now.Year - ano;
            if (idade >= 16)
                Console.WriteLine("Você pode votar.");
            else
                Console.WriteLine("Você não pode votar.");
        }

        static void Questao16()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
                Console.WriteLine($"{numero} é positivo.");
            else
                Console.WriteLine($"{numero} é negativo.");
        }

        static void Questao17()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7.0)
                Console.WriteLine($"Aprovado com média: {media}");
            else
                Console.WriteLine($"Reprovado com média: {media}");
        }

        static void Questao18()
        {
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();
            int contador = 0;
            foreach (char c in str.ToLower())
            {
                if (c == 'a')
                    contador++;
            }
            Console.WriteLine($"A letra 'a' aparece {contador} vezes.");
        }

        static void Questao19()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        static void Questao20()
        {
            Console.WriteLine("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i * i;
            }
            Console.WriteLine($"A soma dos quadrados de 1 até {N} é: {soma}");
        }

        static void Questao21()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bem-vindo(a), {nome}! Você tem {idade} anos.");
        }

        static void Questao22()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dobro: {numero * 2}, Triplo: {numero * 3}");
        }

        static void Questao23()
        {
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
                Console.WriteLine($"Último caractere: {str[str.Length - 1]}");
            else
                Console.WriteLine("String vazia.");
        }

        static void Questao24()
        {
            Console.WriteLine("Digite a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());
            int segundos = horas * 3600;
            Console.WriteLine($"{horas} horas é igual a {segundos} segundos.");
        }

        static void Questao25()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 3 == 0 && numero % 5 == 0)
                Console.WriteLine($"{numero} é divisível por 3 e 5.");
            else
                Console.WriteLine($"{numero} não é divisível por 3 e 5.");
        }

        static void Questao26()
        {
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int c = int.Parse(Console.ReadLine());

            int[] numeros = { a, b, c };
            Array.Sort(numeros);
            Console.WriteLine("Números em ordem: " + string.Join(", ", numeros));
        }

        static void Questao27()
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            long fatorial = Fatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }

        static long Fatorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * Fatorial(numero - 1);
        }

        static void Questao28()
        {
            Aluno aluno = new Aluno { Nome = "João", Nota = 8.5 };
            aluno.ExibirInformacoes();
        }

        class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Nome do Aluno: {Nome}");
                Console.WriteLine($"Nota: {Nota}");
            }
        }

        static void Questao29()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            double[] numeros = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            double media = numeros.Average();
            Console.WriteLine($"A média é: {media}");
        }

        static void Questao30()
        {
            Console.Write("Digite uma palavra para verificar se é um palíndromo: ");
            string palavra = Console.ReadLine();
            string reverso = new string(palavra.Reverse().ToArray());

            if (palavra.Equals(reverso, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("A palavra é um palíndromo.");
            else
                Console.WriteLine("A palavra não é um palíndromo.");
        }

        static void Questao31()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int menor = numeros.Min();
            Console.WriteLine($"O menor número é: {menor}");
        }

        static void Questao32()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            Console.WriteLine("Digite o valor pelo qual multiplicar os números:");
            int multiplicador = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int[] resultado = numeros.Select(n => n * multiplicador).ToArray();
            Console.WriteLine("Resultado da multiplicação: " + string.Join(", ", resultado));
        }

        static void Questao33()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int somaImpares = numeros.Where(n => n % 2 != 0).Sum();
            Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");
        }

        static void Questao34()
        {
            Console.WriteLine("Modelo carro:");
            string nome = Console.ReadLine();
            Console.WriteLine("Ano do carro:");
            int ano = int.Parse(Console.ReadLine());

            Carro carro = new Carro { Nome = nome, Ano = ano };
            carro.ExibirInformacoes();
        }

        class Carro
        {
            public string Nome { get; set; }
            public int Ano { get; set; }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Nome do Carro: {Nome}");
                Console.WriteLine($"Ano: {Ano}");
            }
        }

        static void Questao36()
        {
            int a = 0, b = 1, c;
            Console.Write("Sequência de Fibonacci: ");
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        static void Questao37()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            string novaFrase = frase.Replace(' ', '_');
            Console.WriteLine("Frase modificada: " + novaFrase);
        }

        static void Questao38()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int indiceMaior = Array.IndexOf(numeros, numeros.Max());
            Console.WriteLine($"O índice do maior elemento é: {indiceMaior}");
        }

        static void Questao39()
        {
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int mdc = MDC(a, b);
            Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
        }

        static int MDC(int a, int b)
        {
            return (b == 0) ? a : MDC(b, a % b);
        }

        static void Questao40()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int vogais = frase.Count(c => "AEIOUaeiou".Contains(c));
            Console.WriteLine($"A frase possui {vogais} vogais.");
        }

        static void Questao41()
        {
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine($"O número binário é: {binario}");
        }

        static void Questao42()
        {
            Console.Write("Digite um número de 0 a 9: ");
            int numero = int.Parse(Console.ReadLine());

            string[] palavras = { "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
            if (numero >= 0 && numero <= 9)
                Console.WriteLine($"O número em palavras é: {palavras[numero]}");
            else
                Console.WriteLine("Número fora do intervalo.");
        }

        static void Questao43()
        {
            Random rand = new Random();
            int[] frequencia = new int[6];

            for (int i = 0; i < 100; i++)
            {
                int valor = rand.Next(1, 7);
                frequencia[valor - 1]++;
            }

            Console.WriteLine("Frequência de cada face (em 100 lançamentos):");
            for (int i = 0; i < frequencia.Length; i++)
                Console.WriteLine($"Face {i + 1}: {frequencia[i]} vezes");
        }

        static void Questao44()
        {
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");
        }

        static void Questao45()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int segundoMaior = numeros.OrderByDescending(n => n).Skip(1).FirstOrDefault();
            Console.WriteLine($"O segundo maior número é: {segundoMaior}");
        }

        static void Questao46()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);
            Console.WriteLine("Array invertido: " + string.Join(", ", numeros));
        }

        static void Questao48()
        {
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Dia da semana: " + data.ToString("dddd"));
        }

        static void Questao49()
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
            bool isAlfanumerica = input.All(c => char.IsLetterOrDigit(c));
            Console.WriteLine($"A string contém apenas letras e números: {isAlfanumerica}");
        }

        static void Questao50()
        {
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }
            Console.WriteLine($"Resultado: {resultado}");
        }

        static void Questao51()
        {
            int[,] matriz = {
                {1, 2, 3},
                {2, 1, 4},
                {3, 4, 1}
            };
            bool simetrica = true;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                    {
                        simetrica = false;
                        break;
                    }
                }
            }
            Console.WriteLine(simetrica ? "A matriz é simétrica." : "A matriz não é simétrica.");
        }

        static void Questao52()
        {
            List<string> nomes = new List<string> { "Ana", "Carlos", "Beatriz", "Eduardo" };
            nomes.Sort();
            Console.WriteLine("Nomes ordenados:");
            nomes.ForEach(Console.WriteLine);
        }

        static void Questao53()
        {
            int[] numeros = { 1, 3, 2, 3, 4, 3, 5 };
            var frequente = numeros.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine($"Elemento mais frequente: {frequente}");
        }

        static void Questao54()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int absoluto = numero < 0 ? -numero : numero;
            Console.WriteLine($"Valor absoluto: {absoluto}");
        }

        static void Questao55()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            Console.Write("Digite o número para buscar: ");
            int numero = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numero)
                {
                    encontrado = true;
                    Console.WriteLine($"Número encontrado na posição {i}.");
                    break;
                }
            }
            if (!encontrado)
                Console.WriteLine("Número não encontrado.");
        }

        static void Questao56()
        {
            Console.WriteLine("Cronômetro iniciando... (Pressione Ctrl+C para parar)");
            int segundos = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Tempo: {segundos++} segundos");
                Thread.Sleep(1000);
            }
        }

        static void Questao57()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int palavras = frase.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Número de palavras: {palavras}");
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public void Falar()
            {
                Console.WriteLine($"{Nome} diz: Olá!");
            }
        }

        static void Questao58()
        {
            Pessoa pessoa = new Pessoa { Nome = "João" };
            pessoa.Falar();
        }

        static void Questao59()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            int[] intersecao = array1.Intersect(array2).ToArray();

            Console.WriteLine("Interseção entre os dois arrays:");
            foreach (int num in intersecao)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Questao60()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            char[] resultado = frase.ToCharArray();
            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = i % 2 == 0 ? char.ToUpper(resultado[i]) : char.ToLower(resultado[i]);
            }
            Console.WriteLine(new string(resultado));
        }

        static void Questao61()
        {
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            int caracteresUnicos = input.Distinct().Count();
            Console.WriteLine($"Número de caracteres únicos: {caracteresUnicos}");
        }

        static void Questao62()
        {
            Console.WriteLine("Digite um número:");
            if (int.TryParse(Console.ReadLine(), out int limite))
            {
                Console.WriteLine($"Números primos até {limite}: {string.Join(" ", Enumerable.Range(2, limite - 1).Where(n => n > 1 && !Enumerable.Range(2, (int)Math.Sqrt(n) - 1).Any(i => n % i == 0)))}");
            }
            else
            {
                Console.WriteLine("Numero inválido.");
            }
        }

        static void Questao64()
        {
            Console.WriteLine("Digite um número:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine($"Divisores de {numero}: {string.Join(" ", Enumerable.Range(1, numero).Where(i => numero % i == 0))}");
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro.");
            }
        }

        static void Questao65()
        {
            int[,] matriz = {
                {11, 12, 13},
                {14, 15, 16},
                {17, 18, 19}
            };

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[,] transposta = new int[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("Matriz transposta:");
            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write($"{transposta[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Questao66()
        {
            Console.WriteLine("Pressione Ctrl+C para encerrar.");
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Horário atual: {DateTime.Now:T}");
                Thread.Sleep(1000);
            }
        }

        static void Questao68()
        {
            Console.Write("Digite o valor monetário (exemplo: 123.45): ");
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor por extenso: {ValorParaExtenso(valor)}");
        }

        static string ValorParaExtenso(decimal valor)
        {
            return new CultureInfo("pt-BR", false).TextInfo.ToTitleCase($"{valor:C}".Replace("R$", ""));
        }

        static void Questao70()
        {
            Console.Write("Digite o valor do saque: ");
            int valor = int.Parse(Console.ReadLine());
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            Dictionary<int, int> distribuicao = new Dictionary<int, int>();

            foreach (int nota in notas)
            {
                int quantidadeNotas = valor / nota;
                if (quantidadeNotas > 0)
                {
                    distribuicao[nota] = quantidadeNotas;
                    valor %= nota;
                }
            }

            if (valor > 0)
            {
                Console.WriteLine("O valor inserido não pode ser sacado com as notas disponíveis.");
            }
            else
            {
                Console.WriteLine("Distribuição das notas:");
                foreach (var kvp in distribuicao)
                {
                    Console.WriteLine($"{kvp.Value} nota(s) de R$ {kvp.Key}");
                }
            }
        }

        static void Questao71()
        {
            string[] array1 = { "gato", "cachorro", "pássaro" };
            string[] array2 = { "gato", "cachorro", "pássaro" };

            bool iguais = array1.Length == array2.Length && !array1.Where((t, i) => t != array2[i]).Any();
            Console.WriteLine(iguais ? "Os arrays são iguais." : "Os arrays não são iguais.");
        }

        static void Questao72()
        {
            Console.WriteLine("Digite o comprimento da senha (max 11):");
            if (int.TryParse(Console.ReadLine(), out int comprimento) && comprimento > 0 && comprimento <= 11)
            {
                string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var senha = new HashSet<char>();
                Random random = new Random();

                while (senha.Count < comprimento)
                    senha.Add(caracteres[random.Next(caracteres.Length)]);

                Console.WriteLine($"Senha gerada: {new string(senha.ToArray())}");
            }
        }

        static void Questao73()
        {
            Console.Write("Digite um número para gerar a tabela de multiplicação: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabela de Multiplicação de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        static void Questao74()
        {
            Console.WriteLine("Digite os lados do triângulo:");
            double lado1 = double.Parse(Console.ReadLine());
            double lado2 = double.Parse(Console.ReadLine());
            double lado3 = double.Parse(Console.ReadLine());

            double s = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

            Console.WriteLine($"A área do triângulo é: {area}");
        }

        static void Questao77()
        {
            string[] array1 = { "maçã", "banana", "laranja", "5" };
            string[] array2 = { "laranja", "maçã", "banana" };

            bool iguais = array1.Length == array2.Length && !array1.Except(array2).Any();
            Console.WriteLine(iguais ? "Possui os mesmos elementos." : "Não possui os mesmos elementos.");
        }

        static void Questao80()
        {
            Console.Write("Digite um número (de preferência maior ou igual a 2 dígitos): ");
            string numero = Console.ReadLine();
            int soma = 0;

            foreach (char c in numero)
            {
                if (char.IsDigit(c))
                {
                    soma += int.Parse(c.ToString());
                }
            }

            Console.WriteLine($"A soma dos dígitos do número {numero} é: {soma}");
        }

        static void Questao81()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Digite a quantidade de números que você deseja adicionar à lista:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            ExibirNumerosPares(numeros);
        }

        static void ExibirNumerosPares(List<int> numeros)
        {
            Console.WriteLine("\nNúmeros pares na lista:");
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
        static void Questao83()
        {
            string[] nomes = new string[10];
            Console.WriteLine("Digite 10 nomes:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);
            Console.WriteLine("\nNomes em ordem alfabética:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        static void Questao89()
        {
            Console.WriteLine("Três notas do aluno:");
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"\nMédia do aluno: {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
        static void Questao92()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0 && numero % 7 == 0)
            {
                Console.WriteLine($"O número {numero} é múltiplo de 3 e 7 ao mesmo tempo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é múltiplo de 3 e 7 ao mesmo tempo.");
            }
        }
        static void Questao96()
        {
            Console.WriteLine("Números primos entre 1 e 100:");
            for (int i = 2; i <= 100; i++)
            {
                if (EhPrimo(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        static void Questao97()
        {
            Console.Write("Digite um número para exibir sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        static void Questao99()
        {
            Console.Write("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = SomaDosQuadrados(N);
            Console.WriteLine($"A soma dos quadrados dos números de 1 a {N} é: {soma}");
        }

        static int SomaDosQuadrados(int N)
        {
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i * i;
            }
            return soma;
        }

    }
}