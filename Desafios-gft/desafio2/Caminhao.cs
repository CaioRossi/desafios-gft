namespace desafio2
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

        public override double calcularFrete (double peso, double valor)
        {    
            return (peso * 0.12) + (valor * 0.3);
        }
    } 
}