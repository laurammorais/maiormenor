using System;

namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        //        Escreva um programa que leia 15 valores reais e encontre o maior e o menor
        //deles, mostrando o resultado.
        {
            float num, maior = 0, menor = 0;
            

            for (int i = 0; i < 15; i++)
            {
                Console.Write("digite um numero: ") ;
                num = float.Parse( Console.ReadLine());

                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }
                else if (num > maior)
                {
                    maior = num;
                }           
                else if (num < menor)
                {
                    menor = num; 
                }
            }
            Console.WriteLine("o maior numero é:{0}", maior);
            Console.WriteLine("o menor numero é: {0}", menor);
        }
    }
}
