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

            mercado.AgregarUsuario(42874751, "franco", "Motzo", "francomotzo2000@gmail.com", "pepito", 20);
            mercado.AgregarUsuario(42874751, "Lopez", "Ricardo", "ricardolopez2000@gmail.com", "pepito", 20);
            mercado.AgregarUsuario(42874751, "Ropez", "Picardo", "ricardolopez2000@gmail.com", "pepito", 20);
            Console.WriteLine("-----!!!!!------");
            mercado.MostrarUsuario();
            mercado.EliminarUsuario(1);
            mercado.EliminarUsuario(5);
            Console.WriteLine("-----!!!!!------");
            mercado.MostrarUsuario();
            //mercado.AgregarCategoria("Categoria 1");
            //mercado.AgregarCategoria("Categoria 2");
            //mercado.AgregarCategoria("Categoria 3");
            //mercado.AgregarCategoria("Categoria 4");
            //mercado.AgregarCategoria("Categoria 5");
            //mercado.AgregarCategoria("Categoria 6");
            //mercado.AgregarCategoria("Categoria 7");
            //mercado.AgregarCategoria("Categoria 8");
            //mercado.AgregarCategoria("Categoria 9");
            //mercado.AgregarCategoria("Categoria 10");
            //mercado.AgregarCategoria("Categoria 11");
            //mercado.imprimirEnPantallaCategorias();

            //Console.WriteLine("");

            //mercado.AgregarProducto("Papas Lays", 150, 14, 1);
            //mercado.AgregarProducto("Lentejas", 150, 14, 1);

            //mercado.imprimirProductoEnPantalla();
            //Console.WriteLine("");

            //mercado.BuscarCategoria("Categoria 10");
            //Console.WriteLine("");


            //mercado.ModificarCategoria(1 , "Pepito");
            //mercado.imprimirEnPantallaCategorias();
            //mercado.imprimirEnPantalla(); //producto

            //mercado.EliminarCategoria(1);
            //mercado.imprimirEnPantallaCategorias();

        }
    }
}
