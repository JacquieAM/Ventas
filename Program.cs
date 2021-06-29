using System;

namespace Ventas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nMenu");
            Console.WriteLine("\n1.Comprar");
            Console.WriteLine("\n2.Salir");
            int menuKey = Convert.ToInt32(Console.ReadLine());
            Ticket ticket = new Ticket();
            try
            {
                if (menuKey == 1)
                {
                    ticket.agregarProductos();

                }

            }
            catch (FormatException)
            {
                System.Console.WriteLine("El dato que escribiste no es un numero");
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("El dato no se ha inicializado");
            }
            catch (IndexOutOfRangeException)
            {
                System.Console.WriteLine("El dato esta fuera del arreglo");
            }

            catch (OverflowException)
            {
                System.Console.WriteLine("El dato no puede guardar el valor");
            }

            if (menuKey == 2)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
