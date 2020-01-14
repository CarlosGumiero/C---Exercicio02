using System;

namespace Exercicio02_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Carro carro1;
			carro1 = new Carro("Prisma", 50, 5, 200f, "Ford", 4, 2015);

			Aviao aviao1;
			aviao1 = new Aviao("747 Duplo", 1500, 300, 1000f, "Grande", "Transporte");

			carro1.statusCarro();
			Console.WriteLine("");
			aviao1.statusAviao();
		}
    }
}
