using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace tp1_plataformas
{
    class Mercado
    {
        List<Producto> productos = new List<Producto>();
        List<Usuario> usuarios = new List<Usuario>();

        Categoria[] categorias = new Categoria[maxCategorias];
                
        List<Compra> compras = new List<Compra>();

        const int maxCategorias = 10;
        int cantCategorias = 0;

        public Mercado()
        {
        }

        public bool crearProducto(string nombre, double precio, int Cantidad, int idCategoria)
        {
            int  id = this.productos.Count + 1;
            
            Producto producto = new Producto(id, nombre, precio, Cantidad, idCategoria);
            
            return true;
        }

        public bool agregarProducto(Producto producto, int cantidad)
        {
        
            this.productos.Add(producto);
            return true;
        }

        public void modificarProducto(Producto producto)
        {
            
        }

        public void eliminarProducto()
        {

        }

        public void buscarProductos()
        {


        }

        public void imprimirEnPantalla()
        {
            //Este es para debuguear la creacion de productos e imprimir en pantalla
            for (int i = 0; i < this.productos.Count; i++)
            {
                Console.WriteLine(this.productos[i]);
            }

        }

        public void buscarProductosPorPrecio()
        {

        }

        public void buscarProductosPorCategoria()
        {

        }


        public void agregarUsuario()
        {

        }

        public void modificarUsuario()
        {

        }

        public void eliminarUsuario()
        {

        }

        public void mostrarUsuario()
        {

        }

        public bool agregarCategoria(string nombre)
        {

            //if (this.categorias.Length < maxCategorias)
            //{

            cantCategorias = cantCategorias + 1;

                Categoria categorias = new Categoria(cantCategorias, nombre);
               
                this.categorias[cantCategorias] = categorias;

                return true;
            //}

            //return false;
        }

        public void imprimirEnPantallaCategorias()
        {
            //Este es para debuguear la creacion de productos e imprimir en pantalla
            for (int i = 0; i < this.categorias.Length; i++)
            {
                Console.WriteLine(this.categorias[i]);
            }

        }

        public void modificarCategoria()
        {

        }

        public void eliminarCategoria()
        {

        }

        public void mostrarCategorias()
        {

        }

        public void agregarAlCarro()
        {

        }

        public void quitarDelCarro()
        {

        }

        public void vaciarCarro()
        {

        }

        public void comprar()
        {

        }

        public void modificarCompra()
        {

        }

        public void eliminarCompra()
        {

        }

        public void mostrarTodosLosProductosPorPrecio()
        {

        }

        public void mostrarTodosLosProductosPorCategoria()
        {

        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
