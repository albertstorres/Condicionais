using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAIS IF E ELSE
            int idade = 18;
            int maiorIdade = 21;

            if (idade >= maiorIdade)
                Console.WriteLine("É maior de idade.");
            else
                Console.WriteLine("Não é maior de idade.");
            //FIM CONDICIONAIS IF E ELSE.

            //CONDICIONAIS SWITCH
            int valor = 4;
            string palavra = "Tranquilidade";

            switch (valor) //FUNCIONA COM NÚMEROS
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                default: Console.WriteLine("Nenhuma das opções."); break;
            }

            switch (palavra) //FUNCIONA COM TEXTOS
            {
                case "Palavra": Console.WriteLine("Palavra 1"); break;
                case "Frase": Console.WriteLine("Frase 2"); break;
                case "Paragrafo": Console.WriteLine("Paragrafo 3"); break;
                default: Console.WriteLine("Nada bateu."); break;
            }
            //FIM CONCIONAIS SWITCH
        }
    }
}