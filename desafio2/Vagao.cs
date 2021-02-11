namespace desafio2
{
    public class Vagao : Transporte
    {
        private double peso;
        private double valor;

        public double getPeso(){
            return peso;
        }
        public void setPeso(double valor){
            this.valor = valor;
        }
        public double getValor(){
            return valor;
        }
        public void setValor(double valor){
            this.valor = valor;
        }

        public override double calcularFrete (double peso, double valor){
            double frete = (getPeso() * 0.2) + (getValor() * 0.1);
            
            return frete;
        }
        
    }
}