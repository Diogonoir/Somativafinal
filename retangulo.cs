using System;

namespace Retangulo;

class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite a quantidade de retangulo que você deseja calcular: ");
        int quantidaderetangulo = int.Parse(Console.ReadLine());


        retangulo retangulo = new retangulo();





        for (int i = 0; i < quantidaderetangulo; i++)
            //for que pergunta a quantidade de retangulos desejados
        {


            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("retangulo " + (i + 1));


            Console.WriteLine("Digite a base do retangulo: ");
            retangulo.Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo: ");
            retangulo.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A area do retangulo é " + retangulo.area());
            //calculo da area

            Console.WriteLine("O perímetro do retangulo é " + retangulo.perimetro());
            //calculo do perimetro

            Console.WriteLine("A diagonal do retangulo " + retangulo.diagonal());
            //calculo da diagonal







        }










    }
}

