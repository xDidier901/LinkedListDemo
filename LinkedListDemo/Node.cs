namespace LinkedListDemo
{
    public class Nodo
    {
        public Nodo Siguiente { get; set; }
        public char Valor { get; set; }
        public Nodo(char valor)
        {
            Valor = valor;
        }
    }
}