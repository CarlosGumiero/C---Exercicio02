using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02_CSharp
{
	public class Veiculo
	{

		protected String modelo { get; set; }
		protected int velocidade { get; set; }
		protected int passageiros { get; set; }
		protected float combustivel { get; set; }

		public Veiculo(String modelo, int velocidade, int passageiros, float combustivel)
		{
			this.modelo = modelo;
			this.velocidade = velocidade;
			this.passageiros = passageiros;
			this.combustivel = combustivel;
		}

		public void statusVeiculo()
		{
			Console.WriteLine("Modelo é " + this.modelo + ".");
			Console.WriteLine("A velocidade máxima dele é de " + this.velocidade + " Km/h.");
			Console.WriteLine("Numero de passageiros é de " + this.passageiros + " pessoas.");
			Console.WriteLine("Quantidade máxima de combustível é de " + this.combustivel + " litros.");
		}

	}
}
