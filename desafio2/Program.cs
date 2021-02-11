using System;

namespace desafio2
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da carga: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso da carga: ");
            double peso = double.Parse(Console.ReadLine());

            if (peso < 15000){
                Console.WriteLine($"Frete Caminhão: {Caminhao.calcularFrete(peso, valor)});
                Console.WriteLine($"Frete Vagão: {Vagao.calcularFrete(peso, valor)+5000});
            }

            else if (peso > 40000){
                Console.WriteLine($"Frete Caminhão: {Caminhao.calcularFrete(peso, valor) * 0.75});
                Console.WriteLine($"Frete Vagão: {Vagao.calcularFrete(peso, valor)});
            }
        }
    }
}
