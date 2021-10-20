using System;
using System.Collections.Generic;
using System.Linq;

namespace Blastoff
{
    //Autor: Jonathan Cavalcanti
    class Program
    {
       

        static void Main(string[] args)
        {

            // Exercicio 1
            ///////////////////////////////////////////////////////////////////////////////
            //1 - Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.


            /* int i = 5;
             int j = 10;
             int k = 20;
             int x = 15;
             int y = 25;

             Console.WriteLine("Idade de I: {0}", i);

             Console.WriteLine("Idade de J: {0}", j);

             Console.WriteLine("Idade de K: {0}", k);

             Console.WriteLine("Idade de X: {0}", x);

             Console.WriteLine("Idade de Y: {0}", y);

             int media = ((k + i + j + x + y) / 5);

             Console.WriteLine($"Média de idade é : {(media.ToString("0.0"))}"); */

            // Exercicio 2
            ///////////////////////////////////////////////////////////////////////////////
            // 2 - Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo médio.


            /* float consumomedio, a, b;

             a = 100;
             Console.WriteLine("Distância Total Pecorrida: {0}", a);

             b = 50;
             Console.WriteLine("Combustível gasto: {0}", b);

             consumomedio = a / b;

             Console.WriteLine($"Consumo médio foi de : {(consumomedio.ToString("0.0"))}"); */

            // Exercicio 3
            ///////////////////////////////////////////////////////////////////////////////
            ///3 - Dados três números (a, b, c), faça um algoritmo para mostrar o menor número.

            /*
            int a, b, c;

            a = 10;
            b = 5;
            c = 20;

            if (a < b && a < c)
            {
                Console.WriteLine("A é o menor número");

            } else if (b < a && b < c)
            {
                Console.WriteLine("B é o menor número");

            }
            else if (c < a && c < b)
            {
                Console.WriteLine("B é o menor número");

            } */

            // Exercicio 4
            ///////////////////////////////////////////////////////////////////////////////
            ///4 - Faça um algoritmo que converta a temperatura de C para F
            /*

            float c, f;
            f = 90.5f;
            Console.WriteLine("Temperatura Celsius : {0} ", f);
            c = 5 * (f - 32) / 9;

            Console.WriteLine("Temperatura em Fahrenheit é : {0} ", c);
            */

            // Exercicio 5
            ///////////////////////////////////////////////////////////////////////////////
            // 5 - Faça um algoritmo para apresentar se dois números são múltiplos

            /* int num1, num2;

             num1 = 5;
             num2 = 2;

             Console.WriteLine("Numero 1 : {0} ", num1);
             Console.WriteLine("Numero 2 : {0} ", num2);

             if (num1 % num2 == 0)
             {
                 Console.WriteLine("O numero: {0}" , num1 + " É multiplo de  " + num2);

             }else {
                 Console.WriteLine("O numero: {0}", num1 + " Não é multiplo de  " +  num2);

             }
            */

            // Exercicio 6
            ///////////////////////////////////////////////////////////////////////////////
            /*int horainicio, minutoinicial, horafinal, minutofinal, temporestante,tempoinicial,tempofinal;

            Console.WriteLine("Digite a hora inicial : ");
            horainicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o minuto inicial : ");
            minutoinicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora final : ");
            horafinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os minutos finais : ");
            minutofinal = int.Parse(Console.ReadLine());

            tempoinicial = horainicio * 60 + minutoinicial;
            Console.WriteLine("Tempo Inicial : {0} ", tempoinicial);

            tempofinal = (horafinal * 60) + minutofinal;
            Console.WriteLine("Tempo Final : {0} ", tempofinal);

            if(tempofinal < tempoinicial)
            {
                temporestante = 1440 - tempoinicial;
                temporestante += tempofinal;

                Console.WriteLine("Tempo Decorrido : {0} ", temporestante);

            }
            else
            {
                temporestante = tempofinal - tempoinicial;
                Console.WriteLine("Tempo Decorrido : {0} ", temporestante/60 + " : " + temporestante%60);

            }
            */
            // Exercicio 7
            ///////////////////////////////////////////////////////////////////////////////
            //7 - Dada uma lista de números A[1,2,3,…], faça um algoritmo que retorne uma lista somente com os números pares.

            /*
            List<int> listaParesImpares = new List<int>();
            List<int> listaPares = new List<int>();
            List<int> listaImpares = new List<int>();

            int[] numeros = new int[] {1, 2, 5, 16, 18, 23, 12, 24 };
            listaParesImpares.AddRange(numeros);

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    listaPares.Add(numero);
                }
                else
                {
                    listaImpares.Add(numero);
                }
            }

            Console.WriteLine("Numero Pares : ");
            listaPares.ForEach(Console.WriteLine);
            */

            // Exercicio 8
            ///////////////////////////////////////////////////////////////////////////////
            ///8 - Faça um algoritmo que receba um número e retorne se o número é primo ou não.

            /*    int number, i;
                int resultado = 0;

                Console.WriteLine("Digite um número :");
                number = int.Parse(Console.ReadLine());

                for (i  = 2; i <= number /2; i++)
                {
                    if(number % i == 0)
                    {
                        resultado++;
                        break;
                    }
                }

                if (resultado == 0)
                {
                    Console.WriteLine("{0} É um numero primo :", number);
                }
                else
                {
                    Console.WriteLine("{0} Não é um numero primo :", number);

                } */

            // Exercicio 9
            ///////////////////////////////////////////////////////////////////////////////
            ///9 - Faça um algoritmo que receba um número e retorne a tabuada desse número.
            /*
             int i, numero;


             Console.WriteLine("Digite um número :");
             numero = int.Parse(Console.ReadLine());

             Console.WriteLine("Tabuada de {0} :", numero);
             for (i = 0; i <= 10; i++)
             {
                 Console.WriteLine(numero + " x " + i + " = " + i * numero);

             }
            */
            // Exercicio 10
            ///////////////////////////////////////////////////////////////////////////////
            ///10 - Faça um algoritmo que receba um número e retorne o Fatorial desse número
            /*
            int fatorial, number;

            Console.WriteLine("Digite um número :");
            number = int.Parse(Console.ReadLine());

            for (fatorial = 1; number > 1; number = number - 1)
            {
                fatorial = fatorial * number;
            }
            Console.WriteLine("Fatorial Calculado: {0}", fatorial);

             */

            // Exercicio 11
            ///////////////////////////////////////////////////////////////////////////////
            ///11 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a  intersecção das listas

            /* int[] A = new int[] { 1, 2, 3, 4, 9 };
               int[] B = new int[] { 1, 2, 5, 8, 10 };
               int[] intersecao = new int[5];

               Console.WriteLine("INTERSECÇÃO");
               for (int i = 0; i < intersecao.Length; i++)
               {
                   int iguais = (from b in A where A[i] == B[i] select A[i]).FirstOrDefault();

                   intersecao[i] = iguais;
                   Console.WriteLine(intersecao[i]);

               }
            */
            // Exercicio 12
            ///////////////////////////////////////////////////////////////////////////////
            ///12 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a  concatenação das listas.

            /* int[] A = new int[] { 1, 2, 3, 4 };
            int[] B = new int[] { 1, 2, 5, 8 };
            List<int> concat = A.Concat(B).ToList();
            Console.WriteLine("Lista Concatenada : ");
            concat.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            */

            // Exercicio 13
            ///////////////////////////////////////////////////////////////////////////////
            ///13 - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os valores dessa matriz.
            /*
            int[,] multi = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("A Matriz tem {0} dimensions.", multi.Rank);
            Console.WriteLine("Valores que a Matriz contém: ");
            Console.WriteLine(String.Join(" ", multi.Cast<int>()));

            */

            // Exercicio 14
            ///////////////////////////////////////////////////////////////////////////////
            /// Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo. 
            //(Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice - versa.Ex: osso, Ana e etc).
            /*
              string nome, resultado;

              Console.WriteLine("Digite um nome para verificar se é palíndromo: ");
              nome = Console.ReadLine();

              char[] letra = nome.ToCharArray();
              Array.Reverse(letra);
              resultado = new string(letra);

              bool check = nome.Equals(resultado, StringComparison.OrdinalIgnoreCase);

              if (check == true)
              {
                  Console.WriteLine("O nome : " + nome + " é palíndromo!");
              }
              else
              {
                  Console.WriteLine("O nome : " + nome + " não é palíndromo!");
              }

             */


        }

    }
}