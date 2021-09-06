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

        private int getCategoriaId() //Generamos el ID autoincremental de Categoria
        {
            int contador = 0;

            for (int i = 0; i < this.categorias.Length; i++)
            {
                if (this.categorias[i] != null)
                {
                    contador++;

                }
            }
            return contador + 1;
        }
        public bool agregarCategoria(string nombre) //Agregamos una categoria al array de categorias
        {
            if (getCategoriaId() <= maxCategorias)
            {

                int id = getCategoriaId();

                Categoria categoria = new Categoria(id, nombre);

                int auxiliar = 0;
                int j = 0;

                do
                {
                    if (this.categorias[j] == null)
                    {
                        this.categorias[j] = categoria;
                        auxiliar = 1;
                    }
                    j++;

                } while (auxiliar == 0);


                return true;

            }

            return false;
        }

        public void imprimirEnPantallaCategorias() //Test pra imprimir categorias en pantalla
        {
            //Este metodo es para debuguear la creacion de productos e imprimir en pantalla
            for (int i = 0; i < this.categorias.Length; i++)
            {
                Console.WriteLine(this.categorias[i]);
            }
        }

        public bool agregarProducto(string nombre, double precio, int Cantidad, int idCategoria)//Creamos producto y lo agregamos al array list de productos
        {
            int id = this.productos.Count + 1;

            Producto producto = new Producto(id, nombre, precio, Cantidad, idCategoria);
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

        public void imprimirProductoEnPantalla()
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

        public bool BuscarCategoria(string Nombre)
        {
            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine("abc");

                if (categorias.GetValue(Nombre).Equals(Nombre))
                {

                }
            }
            return true;
        }

        public bool ModificarCategoria(int ID, string Nombre)
        {
            return true;
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
