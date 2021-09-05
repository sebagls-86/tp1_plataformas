using System;
using System.Collections;
using System.Collections.Generic;
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
        int cantCategorias;

        public Mercado()
        {
        }

        public void AgregarProducto()
        {

        }

        public void ModificarProducto()
        {

        }

        public void EliminarProducto()
        {

        }

        public void BuscarProductos()
        {

        }

        public void BuscarProductosPorPrecio()
        {

        }

        public void BuscarProductosPorCategoria()
        {

        }


        public void AgregarUsuario()
        {

        }

        public void ModificarUsuario()
        {

        }

        public void EliminarUsuario()
        {

        }

        public void MostrarUsuario()
        {

        }

        public void AgregarCategoria()
        {

        }

        public void ModificarCategoria()
        {

        }

        public void EliminarCategoria()
        {

        }

        public void MostrarCategorias()
        {

        }

        public void AgregarAlCarro()
        {

        }

        public void QuitarDelCarro()
        {

        }

        public void VaciarCarro()
        {

        }

        public void Comprar()
        {

        }

        public void ModificarCompra()
        {

        }

        public void EliminarCompra()
        {

        }

        public void MostrarTodosLosProductosPorPrecio()
        {

        }

        public void MostrarTodosLosProductosPorCategoria()
        {

        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
