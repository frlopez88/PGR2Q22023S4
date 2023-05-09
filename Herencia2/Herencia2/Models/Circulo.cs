using System;
namespace Herencia2.Models
{
	public class Circulo : FiguraGeometrica
	{
		public double radio { get; set; }

		public Circulo(double r)
		{

			radio = r;
			calcularArea();
			calcularPerimetro();

		}

        public override void calcularArea()
        {
			area = Math.Pow(radio, 2) * Math.PI;
        }

        public override void calcularPerimetro()
        {
			perimetro = 2 * Math.PI * radio;
        }

    }
}

