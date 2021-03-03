namespace desafio3
{
    public class Caminhao : Transporte
    {
        private double peso;
        private double valor;
        public Caminhao(Carga carga) : base(carga)
        {
            this.peso = carga.getPeso();
            this.valor = carga.getValor();
        }

        public override double calcularFrete (Carga carga)
        {
            if (carga.getValor() > 40000)
            {
                return ((carga.getPeso() * 0.12) + (carga.getValor() * 0.3)) * 0.75;
            }

            else
            {
                return (carga.getPeso() * 0.12) + (carga.getValor() * 0.3);
            }
        }
    } 
}