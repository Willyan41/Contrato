using Contrato.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Contrato.Entidades
{
    class Circulo : AbstractFigura
    {
        private double Raio { get; set; }
        private Cores Cor { get; set; }

        public Circulo() { }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public Circulo(double raio, Cores cor)
        {
            Raio = raio;
            Cor = cor;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;

        }

        public override string ToString()
        {
            return  "Cor do circulo = " +
                    Cor +
                    ", raio  = " +
                    Raio.ToString("F2", CultureInfo.InvariantCulture) +
                    ", area = " +
                    Area().ToString("F2", CultureInfo.InvariantCulture);

            
        }


    }
}
