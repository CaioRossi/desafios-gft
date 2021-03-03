using System;

namespace desafios_gft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ser multiplicado: ");
            int multiplicando = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o início do intervalo multiplicador: ");
            int multiInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o final do intervalo multiplicador: ");
            int multiFinal = int.Parse(Console.ReadLine());

            if ((multiplicando < 0 || multiplicando > 3000) || (multiInicio < 0 || multiInicio > 3000) || (multiFinal < 0 || multiFinal > 3000)){
                Console.WriteLine("Os números multiplicado, ou multiplicadores não pode ser negativos ou maiores que 3000!");
            }
            else if ((multiFinal - multiInicio) >= 10 || (multiInicio > multiFinal)){
                Console.WriteLine("Intervalo inválido");
            }
            else {
                for (int i = multiInicio; i <= multiFinal; i++) {
                Console.WriteLine($"{multiplicando} x {i} = {multiplicando * i}");
            }
            }
            
        }
    }
}
