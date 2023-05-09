using System;
namespace Herencia2.Models
{
	public class ClaseCuadrado : FiguraGeometrica
	{

		public double lado1 { get; set; }
		public double lado2 { get; set; }

		public ClaseCuadrado(double l1 , double l2)
		{
			lado1 = l1;
			lado2 = l2;
			calcularArea();
			calcularPerimetro();

        }

		// Polimorfismo

		public override void calcularPerimetro() {

			perimetro = (lado1*2) + (lado2*2);

		}

        public override void calcularArea()
        {
			area = (lado1 * lado2);
        }


    }
}

