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

            mercado.agregarCategoria("1");
            mercado.agregarCategoria("2");
            mercado.agregarCategoria("3");
            mercado.agregarCategoria("4");
            mercado.agregarCategoria("5");
            mercado.agregarCategoria("6");
            mercado.agregarCategoria("7");
            mercado.agregarCategoria("8");
            mercado.agregarCategoria("9");
            mercado.agregarCategoria("10");
            mercado.agregarCategoria("11");

            mercado.imprimirEnPantallaCategorias();

            mercado.agregarProducto("Papas Lays", 150, 14, 1);
            mercado.agregarProducto("Lentejas", 150, 14, 1);

            mercado.imprimirProductoEnPantalla();

            mercado.BuscarCategoria("");
            //mercado.imprimirEnPantalla(); //producto

        }
    }
}
