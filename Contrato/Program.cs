using System;
using Contrato.Entidades;
using Contrato.Enums;


namespace Contrato
{
    class Program
    {
        static void Main(string[] args)
        {

            IFigura Retangulo = new Retangulo(2,3, Cores.Branco) ;
            IFigura Circulo = new Circulo(2, Cores.Preto);

            Console.WriteLine(Retangulo);
            Console.WriteLine(Circulo);

        }
    }
}
