using System;
namespace Herencia2.Models
{
	public class FiguraGeometrica
	{

		public double perimetro { get; set; }
		public double area { get; set; }

		public virtual void calcularPerimetro() {

		}

		public virtual void calcularArea() {

		}

        public override string ToString()
        {
			return $" area:{area} - perimetro: {perimetro}";
        }
    }
}

