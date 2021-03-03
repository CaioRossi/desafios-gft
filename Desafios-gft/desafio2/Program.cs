using System;

namespace desafio2
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da carga: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da carga: ");
            double valor = double.Parse(Console.ReadLine());

            Carga carga = new Carga(valor, peso);
            Caminhao caminhao = new Caminhao(carga);
            Vagao vagao = new Vagao(carga);

            

            if (peso < 15000 && valor > 40000)
            {
                Console.WriteLine($"Frete Caminhão: {caminhao.calcularFrete(peso, valor) * 0.75}");
                Console.WriteLine($"Frete Vagão: {vagao.calcularFrete(peso, valor)+5000}");
            }

            else if (peso < 15000)
            {
                Console.WriteLine($"Frete Caminhão: {caminhao.calcularFrete(peso, valor)}");
                Console.WriteLine($"Frete Vagão: {vagao.calcularFrete(peso, valor)+5000}");
            }

            else if (valor > 40000)
            {
                Console.WriteLine($"Frete Caminhão: {caminhao.calcularFrete(peso, valor) * 0.75}");
                Console.WriteLine($"Frete Vagão: {vagao.calcularFrete(peso, valor)}");
            }
            else 
            {
                Console.WriteLine($"Frete Caminhão: {caminhao.calcularFrete(peso, valor)}");
                Console.WriteLine($"Frete Vagão: {vagao.calcularFrete(peso, valor)}");
            }
        }
    }
}
