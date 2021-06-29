using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    class Ticket : Producto
    {
        public Ticket(String[] nombre, double[] precio) : base ( nombre, precio)
        {

        }
        double total;
        double cantPantalon;
        double cantBlusa;
        double cantZapatos;
        double totalPantalon;
        double totalBlusa;
        double totalZapatos;


       

        public Ticket()
        {
         
        }

        public void agregarProductos()
        {
            String[] nombre = { "pantalon", "blusa", "zapatos" };
            String[] precio = { "500", "200", "800" };
            int menuKey=0;
            do
            {
                Console.WriteLine("Seleccione los productos que desea agregar a su compra");
                Console.WriteLine("1. Pantalon $500");
                Console.WriteLine("2. Blusa $200");
                Console.WriteLine("3. Zapatos $800");
                Console.WriteLine("00. Finalizar Venta");

                menuKey = Convert.ToInt32(Console.ReadLine());
                //int cantidad;


                if (menuKey == 1)
                {
                    Console.WriteLine("Indique la cantidad de Pantalones que desea comprar");
                    cantPantalon = Convert.ToInt32(Console.ReadLine());
                    totalPantalon = cantPantalon * 500;
                    Console.WriteLine("\n Pantalon cantidad " + cantPantalon);

                }

                if (menuKey == 2)
                {
                    Console.WriteLine("Indique la cantidad de Blusas que desea comprar");
                    cantBlusa = Convert.ToInt32(Console.ReadLine());
                    totalBlusa = cantBlusa * 200;
                    Console.WriteLine("\n Blusa cantidad " + cantBlusa);
                }

                if (menuKey == 3)
                {
                    Console.WriteLine("Indique la cantidad de Zapatos que desea comprar");
                    cantZapatos = Convert.ToInt32(Console.ReadLine());
                    totalZapatos = cantZapatos * 800;
                    Console.WriteLine("\n Zapatos cantidad " + cantZapatos);
                }

               
            }
            while (menuKey != 00);
            Console.WriteLine("1. Desea Eliminar un elemento del Ticket");
            Console.WriteLine("2. Cancelar Venta");
            Console.WriteLine("3. Imprimir ticket");


            menuKey = Convert.ToInt32(Console.ReadLine());

            if (menuKey == 1)
            {
                Console.WriteLine("Que producto desea eliminar");
                Console.WriteLine("1. Pantalon");
                Console.WriteLine("2. Blusa");
                Console.WriteLine("3. Zapatos");
                menuKey = Convert.ToInt32(Console.ReadLine());
                int eliminar;
                if (menuKey == 1)
                {
                    Console.WriteLine("\n Pantalon cantidad actual " + cantPantalon);
                    Console.WriteLine("Ingrese la cantidad de productos a eliminar");
                    eliminar = Convert.ToInt32(Console.ReadLine());
                    cantPantalon = cantPantalon - eliminar;
                    Console.WriteLine("\n Pantalon cantidad final " + cantPantalon);
                }
                if (menuKey == 2)
                {
                    Console.WriteLine("\n Blusa cantidad actual " + cantBlusa);
                    Console.WriteLine("Ingrese la cantidad de productos a eliminar");
                    eliminar = Convert.ToInt32(Console.ReadLine());
                    cantBlusa = cantBlusa - eliminar;
                    Console.WriteLine("\n Blusa cantidad final " + cantBlusa);
                }
                if (menuKey == 3)
                {
                    Console.WriteLine("\n Zapatos cantidad actual " + cantZapatos);
                    Console.WriteLine("Ingrese la cantidad de productos a eliminar");
                    eliminar = Convert.ToInt32(Console.ReadLine());
                    cantZapatos = cantZapatos - eliminar;
                    Console.WriteLine("\n Zapatos cantidad final " + cantZapatos);
                }
            }


            if (menuKey == 2)
            {
                Console.WriteLine("\n Su venta ha sido cancelada");
                System.Environment.Exit(0);
            }

            if (menuKey == 3)
            {
                Console.WriteLine("\n Ticket ");
                if (cantPantalon > 0)
                {
                    Console.WriteLine("\n Pantalon - cantidad " + cantPantalon + " Precio unitario $500");
                }
                if (cantBlusa > 0)
                {
                    Console.WriteLine("\n Blusa - cantidad " + cantBlusa + " Precio unitario $200");
                }
                if (cantZapatos > 0)
                {
                    Console.WriteLine("\n Zapatos - cantidad " + cantZapatos + " Precio unitario $800");
                }
                total = totalPantalon + totalBlusa + totalZapatos;
                Console.WriteLine("\n El total de su compra es de: " + total);
            }
              


        }



    }
}
