using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args, int n)
        {
            int Ex;

            Console.WriteLine("========Menu========");
            Console.WriteLine("====Exercício 1=====");
            Console.WriteLine("====Exercício 2=====");
            Console.WriteLine("====Exercício 3=====");
            Console.WriteLine("====Exercício 4=====");
            Console.WriteLine("====Exercício 5=====");
            Console.WriteLine("====Exercício 6=====");
            Console.WriteLine("====Exercício 7=====");

            Ex = int.Parse(Console.ReadLine());

            switch (Ex)
            {
                case 1:
                    Console.WriteLine("Digite um número inteiro:");
                    int num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        num *= -1;
                    }

                    Console.WriteLine("O valor absoluto do número é: " + num);
                    break;
                case 2:
                    Console.Write("Digite um número inteiro: ");
                    int Num = int.Parse(Console.ReadLine());

                    if (Num % 3 == 0 && Num % 5 == 0)
                    {
                        Console.WriteLine(Num + " é múltiplo de 3 e 5");
                    }
                    else if (Num % 4 == 0 && Num % 7 == 0)
                    {
                        Console.WriteLine(Num + " é múltiplo de 4 e 7");
                    }
                    else if (Num % 3 == 0)
                    {
                        Console.WriteLine(Num + " é múltiplo de 3");
                    }
                    else if (Num % 4 == 0)
                    {
                        Console.WriteLine(Num + " é múltiplo de 4");
                    }
                    else if (Num % 5 == 0)
                    {
                        Console.WriteLine(Num + " é múltiplo de 5");
                    }
                    else if (Num % 7 == 0)
                    {
                        Console.WriteLine(Num + " é múltiplo de 7");
                    }
                    else
                    {
                        Console.WriteLine(Num + " não é múltiplo de 3, 4, 5 ou 7");
                    }
                    break;
                case 3:
                    Console.WriteLine("Digite o primeiro número:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número:");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro número:");
                    int num3 = int.Parse(Console.ReadLine());

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine("O maior número é: " + num1);
                    }
                    else if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine("O maior número é: " + num2);
                    }
                    else
                    {
                        Console.WriteLine("O maior número é: " + num3);
                    }

                    break;
                case 4:
                    Console.WriteLine("Digite um número de 1 a 7 para saber quais disciplinas você assiste em cada dia da semana:");
                    int diaDaSemana = int.Parse(Console.ReadLine());

                    switch (diaDaSemana)
                    {
                        case 1:
                            Console.WriteLine("Assitir TV");
                            break;
                        case 2:
                            Console.WriteLine("Disciplina de Física");
                            break;
                        case 3:
                            Console.WriteLine("Disciplina de Química");
                            break;
                        case 4:
                            Console.WriteLine("Disciplina de Biologia");
                            break;
                        case 5:
                            Console.WriteLine("Disciplina de História");
                            break;
                        case 6:
                            Console.WriteLine("Disciplina de Geografia");
                            break;
                        case 7:
                            Console.WriteLine("Jogar Video Game");
                            break;
                        default:
                            Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
                            break;
                    }
                    break;
                case 5:
                    int numero, maior, menor;

                    Console.Write("Digite um número inteiro (0 para sair): ");
                    numero = int.Parse(Console.ReadLine());
                    maior = numero;
                    menor = numero;

                    do
                    {
                        Console.Write("Digite um número inteiro (0 para sair): ");
                        numero = int.Parse(Console.ReadLine());
                        if (numero > maior)
                        {
                            maior = numero;
                        }
                        else if (numero < menor && numero != 0)
                        {
                            menor = numero;
                        }

                    } while (numero != 0);
                    Console.WriteLine("O maior número é: " + maior);
                    Console.WriteLine("O menor número é: " + menor);
                    break;
                case 6:
                    int NumA, NumB = 0;
                    Console.Write("Digite um número inteiro: ");
                    NumA = int.Parse(Console.ReadLine());

                    for (int i = 1; i < NumA; i++)
                    {
                        if (NumA % i == 0)
                        {
                            NumB += i;
                        }
                    }

                    if (NumB == NumA)
                    {
                        Console.WriteLine("é um número perfeito.", NumA);
                    }
                    else
                    {
                        Console.WriteLine("não é um número perfeito.", NumA);
                    }
                    break;
                case 7:
                    int NA, soma = 0, cont = 0;
                    double media;

                    Console.WriteLine("Digite uma sequência de números inteiros (0 para finalizar):");

                    do
                    {
                        NA = int.Parse(Console.ReadLine());
                        if (NA != 0 && NA % 2 == 0)
                        {
                            soma += NA;
                            cont++;
                        }
                    } while (NA != 0);

                    if (cont > 0)
                    {
                        media = soma / cont;
                        Console.WriteLine("A média aritmética dos números pares é: " + media);
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível calcular a média, pois não há números pares na sequência.");
                    }
                    break;
                    //Prova dificil
            }
        }
    }
}
    