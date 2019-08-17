using System;
using System.Text;

namespace LinkedListDemo
{
    public static class LinkedList
    {
        // Variable para tener una referencia del primer nodo.
        private static Nodo _cabeza;

        // Agrega un nuevo nodo al final de la lista.
        // Este proceso es lento ya que tiene que recorrer todos los elementos.
        public static void AgregarAlFinal(char valor)
        {
            // Si la cabeza está vacía, se crea el primer nodo de la lista.
            if (_cabeza == null)
            {
                _cabeza = new Nodo(valor);
                return;
            }

            // Apuntador del primer nodo.
            Nodo nodoActual = _cabeza;

            // Se recorre los nodos hasta llegar al final
            while (nodoActual.Siguiente != null)
            {
                // Se va cambiando de nodo
                nodoActual = nodoActual.Siguiente;
            }

            // Al final de la lista, se agrega el nuevo nodo
            nodoActual.Siguiente = new Nodo(valor);
        }

        // Agrega un nuevo nodo al principio de la lista.
        // Actualiza el valor de la cabeza.
        public static void AgregarAlPrincipio(char valor)
        {
            // Si no se ha agregado ningún nodo, se crea el primero y se establece como 
            // la cabeza.
            if (_cabeza == null)
            {
                _cabeza = new Nodo(valor);
            }

            // Si ya existe la cabeza, se crea otro nodo que apunte
            // la cabeza.
            // Y se actualiza la referencia de la cabeza al nuevo nodo.
            Nodo nuevaCabeza = new Nodo(valor)
            {
                Siguiente = _cabeza
            };
            _cabeza = nuevaCabeza;
        }

        public static void EliminarPorValor(char valor)
        {
            // Si la cabeza está vacía no se puede eliminar algún valor.
            if (_cabeza == null)
            {
                return;
            }

            // Si el valor por eliminar es el de la cabeza, solo se actualiza la 
            // refrencia al siguiente nodo.
            if (_cabeza.Valor == valor)
            {
                _cabeza = _cabeza.Siguiente;
            }

            // Se crea una variable para tener referencia al nodo que vayamos recorriendo.
            Nodo nodoActual = _cabeza;

            // Recorremos los nodos hasta encontrar el valor.
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Valor == valor)
                {
                    nodoActual.Siguiente = nodoActual.Siguiente.Siguiente;
                }
                else
                {
                    nodoActual = nodoActual.Siguiente;
                }
            }
        }

        // Método para imprimir los elementos de la LinkedList.
        public static void ImprimirDatosLinkedList()
        {
            var datosLinkedList = new StringBuilder();

            // Si la lista está vacía, no recorremos nada.
            if (_cabeza == null)
            {
                Console.WriteLine("LinkedList vacía.");
                Console.WriteLine("--------------------------");
                return;
            }

            // Variable para tener un control de nuestro nodo actual.
            Nodo nodoActual = _cabeza;

            // Recorremos nuestra lista.
            while (nodoActual != null)
            {
                datosLinkedList.Append($"[{nodoActual.Valor}] => ");
                nodoActual = nodoActual.Siguiente;
            }

            Console.WriteLine(datosLinkedList.ToString());
            Console.WriteLine("--------------------------");
        }

    }
}