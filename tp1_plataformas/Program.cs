using System;
using static tp1_plataformas.Producto;
namespace tp1_plataformas
{
    class Program
    {
        static void Main(string[] args)
        {

            Mercado mercado = new Mercado();

            // OPCION 1 ALTA DE CATEGORIA
            mercado.AgregarCategoria(Console.ReadLine());

            // OPCION 2 BAJA DE CATEGORIA
            mercado.EliminarCategoria(Convert.ToInt32(Console.ReadLine()));

            // OPCION 3 MODIFICA CATEGORIA
            mercado.ModificarCategoria(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());

            // OPCION 4 MOSTRAR CATEGORIAS EXISTENTES
            mercado.MostrarCategorias();

            // OPCION  5 ALTA DE USUARIO
            mercado.AgregarUsuario(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), true);

            // OPCION 7  MODIFICAR USUARIO En duda D:
            mercado.ModificarUsuario(1, 35233665, "Emma", "KuCohen", "ElMasK09@gmail.com", "CLABE", 30, true);

            // OPCION 8 MOSTRAR USUARIOS EXISTENTES DEL SISTEMA
            mercado.MostrarUsuario();
        
            // OPCION 9 ALTA DE PRODUCTO
            mercado.AgregarProducto(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            // OPCION 10 BAJA DE PRODUCTO
            mercado.EliminarProducto(Convert.ToInt32(Console.ReadLine()));

            // OPCION 11 MODIFICAR PRODUCTO
            mercado.ModificarCategoria(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());

            // OPCION 12 MOSTRAR PRODUCTOS QUE EXISTAN EN EL SISTEMA
            mercado.imprimirProductoEnPantalla();

            // OPCION 13 MOSTRAR PRODUCTOS EXISTENTES EN EL SISTEMA ORDENADOS POR PRECIO.
            mercado.MostrarTodosLosProductosPorPrecio();

            // OPCION 14 MOSTRAR PRODUCTOS QUE EXISTEN EN EL SISTEMA ORDENADOS POR CATEGORIA
            mercado.MostrarTodosLosProductosPorCategoria();

            // OPCION 15 MOSTRAR PRODUCTOS QUE EXISTEN EN EL SISTEMA POR PRECIO
            mercado.MostrarTodosLosProductosPorPrecio();

            // OPCION 16 MOSTRAR PRODUCTOS QUE EXISTEN EN EL SISTEMA POR BUSQUEDA
            mercado.BuscarProductos(Console.ReadLine());

            // OPCION 17 MOSTRAR PRODUCTOS QUE EXISTEN EN EL SISTEMA POR NOMBRE ORDENADO POR PRECIO DE MENOR A MAYOR!!
            mercado.BuscarProductosPorPrecio(Console.ReadLine());

        }
    }
}
