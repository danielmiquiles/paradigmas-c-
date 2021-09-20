using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigmas
{
	class Retangulo
	{
		public double getLargura()
		{
			return largura;
		}

		public void setLargura(double largura)
		{
			this.largura = largura;
		}

		public double getAltura()
		{
			return altura;
		}

		public void setAltura(double altura)
		{
			this.altura = altura;
		}

		private double largura;
		private double altura;

		public double area()
		{
			return this.altura * this.largura;
		}

		public double perimetro()
		{
			return (this.altura * this.largura) * 2;
		}

		public double diagonal()
		{

			double x = Math.Pow(this.altura, 2) + Math.Pow(this.largura, 2);
			Math.Sqrt(x);


			return Math.Sqrt(x);
		}
	}
}
