using System;
using System.Collections.Generic;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carga> listaFrete = new List<Carga>();

            listaFrete.Add(new Carga(18550, 27500));            
            listaFrete.Add(new Carga(8100, 35410));
            listaFrete.Add(new Carga(25700, 3650));
            listaFrete.Add(new Carga(9541, 5799));
            listaFrete.Add(new Carga(25740, 45000));
            listaFrete.Add(new Carga(5000, 90570));
            listaFrete.Add(new Carga(8900, 41000));
            
            SimulacaoCustoFrete simulacao = new SimulacaoCustoFrete();
            simulacao.compararTransportes(listaFrete);
            Console.WriteLine(simulacao.msg);
        }
    }
}
