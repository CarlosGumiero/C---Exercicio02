using Exercicio02_CSharp;
using System;
using System.Collections.Generic;
using System.Text;

public class Aviao : Veiculo
{


		public Aviao(String modelo, int velocidade, int passageiros, float combustivel, String tipo, String uso):base(modelo, velocidade, passageiros, combustivel)
	{
		this.tipo = tipo;
		this.uso = uso;
	}

	private String tipo { get; set; }
	private String uso { get; set; }



	public void statusAviao()
	{
		this.statusVeiculo();
		Console.WriteLine("O tipo dele é " + this.tipo + ".");
		Console.WriteLine("Seu uso é para " + this.uso + ".");
	}
	
}