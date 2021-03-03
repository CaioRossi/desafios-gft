namespace desafio3
{
    public abstract class Transporte
    {
        public Transporte(Carga carga){

        }
        public abstract double calcularFrete(Carga carga);
    }
}