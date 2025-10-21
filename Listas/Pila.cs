namespace Listas
{
    internal class Pila
    {
        private List<string> _letras;
        public Pila()
        {
            _letras = new List<string>();
        }
        public void Agregar(string elemento)
        {
            _letras.Add(elemento);
            Console.WriteLine($"Elemento '{elemento}' agregado a la pila.");
        }
        public void Eliminar()
        {
            if (_letras.Count == 0)
            {
                Console.WriteLine("La pila está vacía. No se puede eliminar ningún elemento.");
                return;
            }
            string elementoEliminado = _letras[_letras.Count - 1];
            _letras.RemoveAt(_letras.Count - 1);
            Console.WriteLine($"Elemento '{elementoEliminado}' eliminado de la pila.");
        }
        public void Imprimir()
        {
            if (_letras.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }
            Console.WriteLine("Elementos en la pila:");
            for (int i = _letras.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(_letras[i]);
            }
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nMenú de la Pila:");
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Eliminar elemento");
                Console.WriteLine("3. Imprimir pila");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el elemento a agregar: ");
                        string elemento = Console.ReadLine();
                        Agregar(elemento);
                        break;
                    case "2":
                        Eliminar();
                        break;
                    case "3":
                        Imprimir();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }

}
