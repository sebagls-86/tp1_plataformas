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

            mercado.AgregarCategoria("1");
            mercado.AgregarCategoria("2");
            mercado.AgregarCategoria("3");
            mercado.AgregarCategoria("4");
            mercado.AgregarCategoria("5");
            mercado.AgregarCategoria("6");
            mercado.AgregarCategoria("7");
            mercado.AgregarCategoria("8");
            mercado.AgregarCategoria("9");
            mercado.AgregarCategoria("10");
            mercado.AgregarCategoria("11");

            mercado.AgregarCategoria("Categoria 1");
            mercado.AgregarCategoria("Categoria 2");
            mercado.AgregarCategoria("Categoria 3");
            mercado.AgregarCategoria("Categoria 4");
            mercado.AgregarCategoria("Categoria 5");
            mercado.AgregarCategoria("Categoria 6");
            mercado.AgregarCategoria("Categoria 7");
            mercado.AgregarCategoria("Categoria 8");
            mercado.AgregarCategoria("Categoria 9");
            mercado.AgregarCategoria("Categoria 10");
            mercado.AgregarCategoria("Categoria 11");
            mercado.imprimirEnPantallaCategorias();

            Console.WriteLine("");

           // mercado.AgregarProducto("Papas Lays", 150, 14, );
           // mercado.AgregarProducto("Lentejas", 150, 14, 1);

            mercado.imprimirProductoEnPantalla();
            Console.WriteLine("");

            mercado.BuscarCategoria("Categoria 10");
            Console.WriteLine("");


            mercado.BuscarCategoria("");
            mercado.ModificarCategoria(1, "Pepito");
            mercado.imprimirEnPantallaCategorias();
            //mercado.imprimirEnPantalla(); //producto

            mercado.EliminarCategoria(1);
            mercado.imprimirEnPantallaCategorias();

        }
    }
}
