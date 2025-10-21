namespace Listas
{
    internal class Cola
    {
        private List<string> _letras;

        public Cola()
        {
            _letras = new List<string>();
        }

        public void Agregar(string elemento)
        {
            _letras.Add(elemento);
            Console.WriteLine($"Elemento '{elemento}' agregado a la cola.");
        }

        public void Eliminar()
        {
            if (_letras.Count == 0)
            {
                Console.WriteLine("La cola está vacía. No se puede eliminar ningún elemento.");
                return;
            }
            string elementoEliminado = _letras[0];
            _letras.RemoveAt(0);
            Console.WriteLine($"Elemento '{elementoEliminado}' eliminado de la cola.");
        }

        public void Imprimir()
        {
            if (_letras.Count == 0)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }
            Console.WriteLine("Elementos en la cola:");
            foreach (var letra in _letras)
            {
                Console.WriteLine(letra);
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nMenú de la Cola:");
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
