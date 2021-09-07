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

            mercado.agregarCategoria("Categoria 1");
            mercado.agregarCategoria("Categoria 2");
            mercado.agregarCategoria("Categoria 3");
            mercado.agregarCategoria("Categoria 4");
            mercado.agregarCategoria("Categoria 5");
            mercado.agregarCategoria("Categoria 6");
            mercado.agregarCategoria("Categoria 7");
            mercado.agregarCategoria("Categoria 8");
            mercado.agregarCategoria("Categoria 9");
            mercado.agregarCategoria("Categoria 10");
            mercado.agregarCategoria("Categoria 11");
            mercado.imprimirEnPantallaCategorias();

            Console.WriteLine("");

            mercado.agregarProducto("Papas Lays", 150, 14, 1);
            mercado.agregarProducto("Lentejas", 150, 14, 1);

            mercado.imprimirProductoEnPantalla();
            Console.WriteLine("");

            mercado.BuscarCategoria("Categoria 10");
            Console.WriteLine("");


            mercado.ModificarCategoria(1 , "Pepito");
            mercado.imprimirEnPantallaCategorias();
            //mercado.imprimirEnPantalla(); //producto

            mercado.eliminarCategoria(1);
            mercado.imprimirEnPantallaCategorias();

        }
    }
}
