using Contrato.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace Contrato.Entidades
{
    class Retangulo : AbstractFigura
    {

        private double Altura { get; set; }
        private double Largura { get; set; }
        private Cores Cor { get; set; }

        public Retangulo() { }

        public Retangulo(double altura, double largura)
        {

            Altura = altura;
            Largura = largura;
        }

        public Retangulo(double altura, double largura, Cores cor)
        {

            Altura = altura;
            Largura = largura;
            Cor = cor;
        }

        public override double Area()
        {
            return Altura * Largura;

        }

        public override string ToString()
        {
            return "Cor do retangulo = " +
                    Cor +
                    ", largura  = " +
                    Largura.ToString("F2", CultureInfo.InvariantCulture) +
                    ", altura = " +
                    Largura.ToString("F2", CultureInfo.InvariantCulture) +
                    ", area = " +
                    Area().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
