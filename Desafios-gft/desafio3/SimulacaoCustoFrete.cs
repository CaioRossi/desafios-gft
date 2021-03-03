using System;
using System.Collections.Generic;

namespace desafio3
{
    public class SimulacaoCustoFrete
    {

        private double totalFrete = 0;
        private int totalCaminhao = 0;
        private int totalVagao = 0;
        public string msg = "";
        public SimulacaoCustoFrete()
        {
        }

        public string compararTransportes(List<Carga> cargas)
        {  

            foreach (Carga carga in cargas)
            {

                Caminhao caminhao = new Caminhao(carga);
                Vagao vagao = new Vagao(carga);

                var freteCaminhao = caminhao.calcularFrete(carga);
                var freteVagao = vagao.calcularFrete(carga);

                if (freteCaminhao <= freteVagao)
                {
                    totalCaminhao++;
                    totalFrete += freteCaminhao;
                }
                else 
                {
                    totalVagao++;
                    totalFrete += freteVagao;
                }
                
            }

            msg = $"\nO número de caminhões necessários será: {totalCaminhao} \nO número de vagões necessários será: {totalVagao} \nO total valor total do frete é: {totalFrete}\n";

            return msg;

        }
    }
}