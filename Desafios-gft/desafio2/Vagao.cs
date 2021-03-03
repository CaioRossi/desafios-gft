namespace desafio2
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

        public override double calcularFrete (double peso, double valor)
        {            
            return (peso * 0.2) + (valor * 0.1);
        }  
    }
}