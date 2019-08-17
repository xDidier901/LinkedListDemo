using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedListDemo!");
            Console.WriteLine();
            Console.WriteLine();

            LinkedList.ImprimirDatosLinkedList();
            LinkedList.AgregarAlFinal('u');
            LinkedList.ImprimirDatosLinkedList();
            LinkedList.AgregarAlPrincipio('o');
            LinkedList.ImprimirDatosLinkedList();
            LinkedList.AgregarAlPrincipio('i');
            LinkedList.ImprimirDatosLinkedList();
            LinkedList.AgregarAlPrincipio('e');
            LinkedList.ImprimirDatosLinkedList();
            LinkedList.AgregarAlPrincipio('a');
            LinkedList.ImprimirDatosLinkedList();
            LinkedList.AgregarAlPrincipio('a');
            LinkedList.ImprimirDatosLinkedList();
            LinkedList.EliminarPorValor('a');
            LinkedList.ImprimirDatosLinkedList();

            Console.ReadLine();
        }
    }
}
