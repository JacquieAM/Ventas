using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    class Producto
    {
         
         protected String[] nombre;
         protected double[] precio;
         static int contadorProductos;
         int idProducto;
         

        public Producto(String[] nombre, double[] precio)
        {
            
            this.nombre = nombre;
            this.precio = precio;
        }

        public Producto()
        {
            
            this.idProducto = ++Producto.contadorProductos;
        }


        public void info()
        {
            Console.WriteLine("\n ID Producto: " + idProducto);
            Console.WriteLine("\n Nombre: " + nombre);
            Console.WriteLine("\n Precio: " + precio);

        }

        public int IdProducto
        {
            get { return this.idProducto; }
            set { this.idProducto = idProducto; }
        }

        public String[] Nombre
        {
            get { return this.nombre; }
            set { this.nombre = nombre; }
        }

        public double[] Precio
        {
            get { return this.precio; }
            set { this.precio = precio; }
        }

       
    }
}
