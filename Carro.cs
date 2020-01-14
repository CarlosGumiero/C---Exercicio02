using Exercicio02_CSharp;
using System;
using System.Collections.Generic;
using System.Text;

public class Carro : Veiculo
{

	private String marca { get; set; }
	private int portas { get; set; }
	private int ano { get; set; }

	public Carro(String modelo, int velocidade, int passageiros, float combustivel, String ma, int po, int an):base(modelo, velocidade, passageiros, combustivel)
	{
		this.marca = ma;
		this.portas = po;
		this.ano = an;
	}

	public void statusCarro()
	{
		base.statusVeiculo();
		Console.WriteLine("A marca dele é " + this.marca + ".");
		Console.WriteLine("Ele possui " + this.portas + " portas.");
		Console.WriteLine("Ele é do ano de " + this.ano + ".");
	}

}
