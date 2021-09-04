using System;
using static tp1_plataformas.Producto;
namespace tp1_plataformas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Mercado mercado = new Mercado();

            //Categoria alimentos = new Categoria(1, "Alimentos");
            //Categoria bebidas = new Categoria(2, "Bebidas");
            //Console.WriteLine(alimentos.ToString());

            //Producto producto = new Producto();

           
           // mercado.agregarProducto(producto.setIdProducto(), "alimento dos", 10, 1, alimentos.setIdCategoria());
           
           // mercado.imprimirEnPantalla();

            mercado.agregarCategoria("Alimentos");
            mercado.agregarCategoria("Bebidas");
            mercado.agregarCategoria("Lacteos");

            //Producto papasLays = new Producto("Papas Lays", 150, 1, 1);
            //Producto cocacola = new Producto("Coca Cola", 250, 13, 2);
            
            mercado.crearProducto("Papas Lays", 150, 14, 1);
            //mercado.agregarProducto(producto, 150);
            //mercado.imprimirEnPantallaCategorias();

            mercado.imprimirEnPantalla();

        }
    }
}
