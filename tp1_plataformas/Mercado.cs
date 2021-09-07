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

        public bool AgregarProducto(string nombre, double precio, int Cantidad, Categoria idCategoria)//Creamos producto y lo agregamos al array list de productos
        {
            int id = this.productos.Count + 1;

            Producto producto = new Producto(id, nombre, precio, Cantidad, idCategoria);
            this.productos.Add(producto);
            return true;
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


        public void AgregarUsuario( int dni, String nombre, String apellido, String mail, String password, int cuil)
        {
            int id = this.usuarios.Count + 1;
            Carro micarro = new Carro();
            ClienteFinal cliente = new ClienteFinal(id, dni, nombre, apellido, mail, password, micarro, cuil);
            usuarios.Add(cliente);
            Console.WriteLine("Usuario creado con exito");
        }

        public void ModificarUsuario()
        {

        }

        public void EliminarUsuario(int id)
        {
            usuarios.RemoveAt(id-1);
        }

        public void MostrarUsuario()
        {
            Console.WriteLine("Estos son los Usuarios registrados:");
            for (int i = 0; i < this.usuarios.Count; i++)
            {
                Console.WriteLine(usuarios[i].Id + "-" + usuarios[i].Nombre + "-" + usuarios[i].Mail + "-" + usuarios[i].Dni);
            }
        }

        public bool AgregarCategoria(string nombre) //Agregamos una categoria al array de categorias
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

        public bool ModificarCategoria(int ID, string Nombre)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Id == ID)
                {
                    categoria.Nombre = Nombre;
                }
            }

            return true;
        }

        public bool EliminarCategoria(int ID)
        {

            for (int i = 0; i < this.categorias.Length; i++)
            {
                if (this.categorias[i].Id == ID)
                {
                    this.categorias[i] = null;
                }
            }

            return true;
        }

        public bool BuscarCategoria(string Nombre)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Nombre.Equals(Nombre))
                {
                    Console.WriteLine(categoria.Nombre);
                }


            }
            return true;
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

        public void imprimirProductoEnPantalla()
        {
            //Este es para debuguear la creacion de productos e imprimir en pantalla
            for (int i = 0; i < this.productos.Count; i++)
            {
                Console.WriteLine(this.productos[i]);
            }

        }
        public void imprimirEnPantallaCategorias() //Test pra imprimir categorias en pantalla
        {
            //Este metodo es para debuguear la creacion de productos e imprimir en pantalla
            for (int i = 0; i < this.categorias.Length; i++)
            {
                Console.WriteLine(this.categorias[i]);
            }
        }
    }
}
