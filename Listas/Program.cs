namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Selecciona una opción");
                Console.WriteLine("1. Pila");
                Console.WriteLine("2. Cola");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Pila pila = new Pila();
                    pila.Menu();
                }
                else if (opcion == "2")
                {
                    Cola cola = new Cola();
                    cola.Menu();
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
