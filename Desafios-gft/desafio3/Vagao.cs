namespace desafio3
{
    public class Vagao : Transporte
    {
        private double peso;
        private double valor;

        public Vagao(Carga carga) : base(carga)
        {
            this.peso = carga.getPeso();
            this.valor = carga.getValor();
        }

        public override double calcularFrete (Carga carga)
        {   
            if (carga.getPeso() < 15000)         
            {
                return ((carga.getPeso() * 0.2) + (carga.getValor() * 0.1)) + 5000;
            }
            else
            {
                return (carga.getPeso() * 0.2) + (carga.getValor() * 0.1);
            }
            
        }  
    }
}