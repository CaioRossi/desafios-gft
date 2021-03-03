namespace desafio2
{
    public abstract class Transporte
    {
        public Transporte(Carga carga){

        }
        public abstract double calcularFrete(double peso, double valor);
    }
}