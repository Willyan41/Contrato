using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Contrato.Entidades
{
    abstract class AbstractFigura : IFigura
    {
        public Color Cor { get; set; }

        public abstract double Area();
    }
}
