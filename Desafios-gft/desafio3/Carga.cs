namespace desafio3
{
    public class Carga 
    {
        private double valor;
        private double peso;

        public Carga(double valor, double peso)
        {
            this.valor = valor;
            this.peso = peso;
        }

        public double getPeso(){
            return peso;
        }
        private void setPeso(double peso){
            this.peso = peso;
        }
        public double getValor(){
            return valor;
        }
        private void setValor(double valor){
            this.valor = valor;
        }
    }
}