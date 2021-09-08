using System;
using static tp1_plataformas.Producto;
namespace tp1_plataformas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Mercado mercado = new Mercado();

            mercado.AgregarUsuario(42874751, "franco", "Motzo", "francomotzo2000@gmail.com", "pepito", 20, true);
            mercado.AgregarUsuario(42874751, "Lopez", "Ricardo", "ricardolopez2000@gmail.com", "pepito", 20, false);
            mercado.AgregarUsuario(42874751, "Ropez", "Picardo", "ricardolopez2000@gmail.com", "pepito", 20, false);
            Console.WriteLine("-----!!!!!------");
            mercado.MostrarUsuario();
            //mercado.EliminarUsuario(3);
            //mercado.EliminarUsuario(5);
            Console.WriteLine("-----!!!!!------");
 
            Console.WriteLine("-----Modifico Usuarios------");
            mercado.ModificarUsuario(1, 35233665, "Emma", "KuCohen", "ElMasK09@gmail.com", "CLABE", 30, true);
            //mercado.ModificarUsuario(1, 35233665, "Emma", "KuCohen", "ElMasK09@gmail.com", "CLABE", 30, true);          
            mercado.MostrarUsuario();

            Console.WriteLine("-----CATEGORIAS------");
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
            Console.WriteLine("-----!!!!!------");
            Console.WriteLine("-----Categorias------");
            mercado.MostrarCategorias();

            Console.WriteLine("");

            mercado.AgregarProducto("Papas Lays", 150, 14, 1);
            mercado.AgregarProducto("Lentejas", 130, 14, 2);
            mercado.AgregarProducto("Garbanzos", 120, 14, 2);

            mercado.imprimirProductoEnPantalla();
            //Console.WriteLine("");

            //mercado.BuscarCategoria("Categoria 10");
            //Console.WriteLine("");

            mercado.ModificarCategoria(1 , "Pepito");
            mercado.imprimirProductoEnPantalla();
            //mercado.imprimirEnPantallaCategorias();
            //mercado.imprimirEnPantalla(); //producto

            mercado.EliminarCategoria(1);
            mercado.imprimirProductoEnPantalla();

            Console.WriteLine("-----!!!!!------");
            Console.WriteLine("-----PRODUCTOS POR PRECIO------");
            mercado.MostrarTodosLosProductosPorPrecio();

            Console.WriteLine("-----!!!!!------");
            Console.WriteLine("-----PRODUCTOS POR CATEGORIA------");
            mercado.MostrarTodosLosProductosPorCategoria();

            
        }
    }
}
