using System;
using System.Globalization;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {

            String produto1 = "Computador";
            String produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, código {1} e genero {2}", idade, codigo, genero);

            Console.WriteLine("Medida com 8 casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arrendodado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador por ponto: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}