namespace desafio3
{
    public class Lista
    {
        public double Peso { get; private set; }
        public double Valor { get; private set; }
        
        public Lista()
        {
        }
        
        public Lista(double peso, double valor)
        {
            Peso = peso;
            Valor = valor;
        }
    }
}