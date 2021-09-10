ï»¿using System;
using System.Collections.Generic;
using System.Linq;

namespace tp1_plataformas
{
    class Mercado
    {
        public List<Producto> productos { get; set; }
        public List<Usuario> usuarios { get; set; }
        public Categoria[] categorias { get; set; }

        public List<Compra> compras { get; set; }

        const int maxCategorias = 10;


        public Mercado()
        {
            productos = new List<Producto>();
            usuarios = new List<Usuario>();
            compras = new List<Compra>();
            categorias = new Categoria[maxCategorias];


        }


        private int getCategoriaId() //Generamos el ID autoincremental de Categoria
        {
            int cantCategorias = 0;

            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {
                    cantCategorias++;

                }
            }
            return cantCategorias + 1;
        }

        public bool AgregarProducto(string nombre, double precio, int Cantidad, int idCategoria)//Creamos producto y lo agregamos al array list de productos
        {
            int id = this.productos.Count + 1;


            for (int i = 0; i < this.categorias.Length; i++)
            {

                if (categorias[i] != null && categorias[i].Id == idCategoria)
                {
                    Producto producto = new Producto(id, nombre, precio, Cantidad, categorias[i]);
                    this.productos.Add(producto);
                }



            }

            return true;
        }

        public bool ModificarProducto(int ID, string Nombre, double Precio, int Cantidad, int ID_Categoria)
        {
            return true;
        }

        public bool EliminarProducto(int id)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id.Equals(id))
                {

                    productos.RemoveAll(producto => producto.Id == id);
                    Console.WriteLine("Producto " + id + " eliminado con Ã©xito!");
                    break;

                }
                else
                {
                    Console.WriteLine("Producto " + id + " no encontrado!");
                }
            }
            return true;

        }

        public void BuscarProductos(String Query)
        {
            List<Producto> productosBuscados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Contains(Query))
                {

                    productosBuscados.Add(producto);
                }

            }

            productos.Sort();
            // var ordenada = productosBuscados.OrderBy(producto => producto.Nombre);
            foreach (Producto p in productos)
            {
                Console.WriteLine(p.Nombre + " - " + p.Precio);
            }


        }

        public void BuscarProductosPorPrecio(String Query)
        {
            List<Producto> productosBuscados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Contains(Query))
                {

                    productosBuscados.Add(producto);
                }

            }
            var ordenada = productosBuscados.OrderByDescending(producto => producto.Nombre).ThenBy(producto => producto.Precio);
            foreach (Producto p in ordenada)
            {

                Console.WriteLine("{0} - {1}", p.Nombre, p.Precio);

            }

        }

        public void BuscarProductosPorCategoria(int ID_Categoria)
        {

            foreach (Producto producto in productos)
            {
                if (producto.Cat.Equals(ID_Categoria))
                {
                    productos.Sort();
                    Console.WriteLine(producto.Nombre);
                }

            }

        }


        public bool AgregarUsuario(int dni, String nombre, String apellido, String mail, String password, int cuil, bool esEmpresa)
        {

            int id = usuarios.Count + 1;
            Carro micarro = new Carro(id);
            if (esEmpresa)
            {
                Usuario empresa = new Empresa(id, dni, nombre, apellido, mail, password, micarro, cuil);
                usuarios.Add(empresa);
                Console.WriteLine("La empresa fue creada con exito");
            }
            else
            {
                Usuario cliente = new ClienteFinal(id, dni, nombre, apellido, mail, password, micarro, cuil);
                usuarios.Add(cliente);
                Console.WriteLine("Usuario creado con exito");
            }

            return true;

        }
        public bool ModificarUsuario(int ID, int DNI, string Nombre, string Apellido, string Mail, string Password, int CUIT_CUIL, bool EsEmpresa)
        {

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Id == ID)
                {
                    usuarios[i].Nombre = Nombre;
                    usuarios[i].Apellido = Apellido;
                    usuarios[i].Dni = DNI;
                    usuarios[i].Mail = Mail;
                    usuarios[i].Password = Password;
                    if (!EsEmpresa)
                    {
                        ClienteFinal c = (ClienteFinal)usuarios[i];
                        c.Cuil = CUIT_CUIL;
                    }
                    else
                    {
                        Empresa c = (Empresa)usuarios[i];
                        c.Cuit = CUIT_CUIL;
                    }
                }
            }

            return true;
        }



        public bool EliminarUsuario(int id)
        {

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Id.Equals(id))
                {
                    usuarios.RemoveAll(usuario => usuario.Id == id);
                    Console.WriteLine("Usuario " + id + " eliminado con Ã©xito!");
                    break;

                }
                else
                {
                    Console.WriteLine("Usuario " + id + " no encontrado!");
                }

            }
            return true;

        }

        public void MostrarUsuario()
        {
            Console.WriteLine("Estos son los Usuarios registrados:");
            for (int i = 0; i < usuarios.Count; i++)
            {
                usuarios.Sort();
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
                    if (categorias[j] == null)
                    {
                        categorias[j] = categoria;
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

            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i].Id == ID)
                {
                    categorias[i] = null;
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
            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);
            }
        }

        public bool AgregarAlCarro(int Id_Producto, int Cantidad, int Id_Usuario)
        {
            bool sePudoAgregar = false;
            Usuario usuarioEncontrado;
            Producto productoEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Producto, Cantidad, Id_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", Id_Usuario);
            }
            else if (!MercadoHelper.ExisteElProducto(Id_Producto, productos))
            {
                Console.WriteLine("El producto con id {0} no se pudo encontrar", Id_Producto);
            }
            else
            {
                usuarioEncontrado = usuarios.Find(usuario => usuario.Id == Id_Usuario);
                productoEncontrado = productos.Find(producto => producto.Id == Id_Producto);
                if (Cantidad > productoEncontrado.Cantidad)
                {
                    Console.WriteLine("La cantidad que se quiere agregar es mayor al stock disponible.");
                }
                else
                {
                    usuarioEncontrado.MiCarro.AgregarProducto(productoEncontrado, Cantidad);
                    productoEncontrado.Cantidad -= Cantidad;
                    sePudoAgregar = true;

                    Console.WriteLine("El producto {0} con cantidad {1} se ha añadido al carro del usuario {2}.", productoEncontrado.Nombre, Cantidad, usuarioEncontrado.Nombre);

                }
            }
            return sePudoAgregar;
        }

        public bool QuitarDelCarro(int Id_Producto, int Cantidad, int Id_Usuario)
        {
            bool sePudoDisminuir = false;
            Usuario usuarioEncontrado;
            Producto productoEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Producto, Cantidad, Id_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", Id_Usuario);
            }
            else if (!MercadoHelper.ExisteElProducto(Id_Producto, productos))
            {
                Console.WriteLine("El producto con id {0} no se pudo encontrar", Id_Producto);
            }
            else
            {
                usuarioEncontrado = usuarios.Find(usuario => usuario.Id == Id_Usuario);
                productoEncontrado = productos.Find(producto => producto.Id == Id_Producto);
                if (!usuarioEncontrado.MiCarro.Productos.ContainsKey(productoEncontrado))
                {
                    Console.WriteLine("El producto {0} no se encuentra en el carro de {1}.", productoEncontrado, usuarioEncontrado.Nombre);
                }
                else if (usuarioEncontrado.MiCarro.Productos[productoEncontrado] < Cantidad || Cantidad == 0)
                {
                    productoEncontrado.Cantidad += usuarioEncontrado.MiCarro.Productos[productoEncontrado];
                    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                    Console.WriteLine("El producto {0} ha sido removido en su totalidad del carro del usuario {1}.", productoEncontrado.Nombre, usuarioEncontrado.Nombre);
                }
                else
                {

                    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                    productoEncontrado.Cantidad += Cantidad;
                    sePudoDisminuir = true;
                    Console.WriteLine("El producto {0} con cantidad {1} se ha removido del carro del usuario {2}.", productoEncontrado.Nombre, Cantidad, usuarioEncontrado.Nombre);

                }
            }
            return sePudoDisminuir;
        }

        public bool VaciarCarro(int Id_Usuario)
        {

            bool sePudoVaciar = false;
            Usuario usuarioEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", Id_Usuario);
            }
            else
            {
                usuarioEncontrado = usuarios.Find(usuario => usuario.Id == Id_Usuario);

                foreach (Producto producto in usuarioEncontrado.MiCarro.Productos.Keys)
                {
                    productos.Find(product => product.Id == producto.Id).Cantidad += usuarioEncontrado.MiCarro.Productos[producto];
                }
                usuarios.Find(usuario => usuario.Id == Id_Usuario).MiCarro.Vaciar();
                Console.WriteLine("Se ha vaciado el carro correctamente.");
                sePudoVaciar = true;
            }
            return sePudoVaciar;

        }


        public bool Comprar(int ID_Usuario)
        {

            //   Busca el usuario pasado como parÃ¡metro 

            //Le pide su carro y a este los productos con la cantidad respectiva.

            //En base a esto calcula el total segÃºn el tipo de usuario, 
            //       a la hora de hacer una compra existe una diferencia si el usuario es
            //       ClienteFinal o Empresa ya que este Ãºltimo paga 21 % menos(descuenta IVA),
            //       esto se debe ver reflejado en el total de la compra.

            //Crea un nuevo elemento compra con el detalle necesario
            //       (ID auto - incremental, Comprador = ID_Usuario, Productos copiando los
            //       elementos del carrito a un nuevo diccionario(Â¡cuidado con las referencias!)
            //       y el total segÃºn calculado).

            //Disminuye el stock de los productos segÃºn lo comprado por el usuario. 

            //Luego vacÃ­a el carrito del usuario. 

            //Muestra el resultado por pantalla(ToString de la compra recientemente creada) 
            //       y devuelve el valor correspondiente indicando si la ejecuciÃ³n fue correcta.


            return true;
        }

        public bool ModificarCompra(int ID, double Total)
        {

            //Solo se permite modificar el total en caso que haya un error de facturaciÃ³n.
            //El resto de los datos no pueden ser modificados.

            return true;
        }

        public bool EliminarCompra(int ID)
        {
            // Nuestro ÂbotÃ³n de arrepentimientoÂ


            return true;
        }

        public void MostrarTodosLosProductosPorPrecio()
        {
            var productoPorPrecio = productos.OrderBy(producto => producto.Precio);
            foreach (Producto p in productoPorPrecio)
            {
                Console.WriteLine(p);
            }

        }

        public void MostrarTodosLosProductosPorCategoria()
        {

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);

                foreach (Producto producto in productos)
                {
                    if (producto.Cat.Equals(categorias[i]))
                    {
                        Console.WriteLine(producto.Nombre);
                    }
                }
            }

        }


        public void imprimirProductoEnPantalla()
        {
            //Este es para debuguear la creacion de productos e imprimir en pantalla
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine(productos[i].ToString());
            }

        }

    }
}