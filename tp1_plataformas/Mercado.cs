using System;
using System.Collections.Generic;


namespace tp1_plataformas
{
    class Mercado
    {
        List<Producto> productos = new List<Producto>();
        List<Usuario> usuarios = new List<Usuario>();
        Categoria[] categorias = new Categoria[maxCategorias];

        List<Compra> compras = new List<Compra>();

        const int maxCategorias = 10;

        private int getCategoriaId() //Generamos el ID autoincremental de Categoria
        {
            int cantCategorias = 0;

            for (int i = 0; i < this.categorias.Length; i++)
            {
                if (this.categorias[i] != null)
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
                    Console.WriteLine("Producto " + id + " eliminado con éxito!");
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
            //Muestra por pantalla, ordenado por Nombre, los productos que 
            //contienen en su nombre la cadena ingresada por el usuario
            //para la búsqueda.
        }

        public void BuscarProductosPorPrecio(String Query)
        {
            //Muestra por pantalla, ordenado por Precio de menor a mayor, 
            //los productos que contienen en su nombre la cadena ingresada 
            //por el usuario para la búsqueda.
        }

        public void BuscarProductosPorCategoria(int ID_Categoria)
        {

            foreach (Producto producto in productos)
            {
                if (producto.Cat.Equals(ID_Categoria))
                {
                    Console.WriteLine(producto.Nombre);
                }

            }

        }


        public void AgregarUsuario(int dni, String nombre, String apellido, String mail, String password, int cuil, bool esEmpresa)
        {

            int id = this.usuarios.Count + 1;
            Carro micarro = new Carro();
            if (esEmpresa)
            {
                Empresa empresa = new Empresa(id, dni, nombre, apellido, mail, password, micarro, cuil);
                usuarios.Add(empresa);
                Console.WriteLine("La empresa fue creada con exito");
            }
            else
            {
                ClienteFinal cliente = new ClienteFinal(id, dni, nombre, apellido, mail, password, micarro, cuil);
                usuarios.Add(cliente);
                Console.WriteLine("Usuario creado con exito");
            }

        }
        public bool ModificarUsuario(int ID, int DNI, string Nombre, string Apellido, string Mail, string Password, int CUIT_CUIL, bool EsEmpresa)
        {

            for (int i = 0; i < this.usuarios.Count; i++)
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
                    Console.WriteLine("Usuario " + id + " eliminado con éxito!");
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
            for (int i = 0; i < this.categorias.Length; i++)
            {
                Console.WriteLine(this.categorias[i]);
            }
        }

        public bool AgregarAlCarro(int ID_Producto, int Cantidad, int ID_Usuario)
        {
            //   Pide al usuario el carro.
            //   Si el parámetro Cantidad es menor a la Cantidad(atributo) del producto 
            //       “ID_Producto” (hay stock), agrega el Producto al carro del usuario.
            //Si no hay stock devuelve falso. 
            //Nota: En este punto no decremento el atributo Cantidad en la clase Producto
            //       ya que el usuario todavía NO realizó la compra.

            return true;
        }

        public bool QuitarDelCarro(int ID_Producto, int Cantidad, int ID_Usuario)
        {

            //Disminuye la cantidad del producto ID_Producto en el carro del usuario.


            return true;
        }

        public bool VaciarCarro(int ID_Usuario)
        {
            //vacía el carro del usuario.
            return true;
        }

        public bool Comprar(int ID_Usuario)
        {

            //   Busca el usuario pasado como parámetro 

            //Le pide su carro y a este los productos con la cantidad respectiva.

            //En base a esto calcula el total según el tipo de usuario, 
            //       a la hora de hacer una compra existe una diferencia si el usuario es
            //       ClienteFinal o Empresa ya que este último paga 21 % menos(descuenta IVA),
            //       esto se debe ver reflejado en el total de la compra.

            //Crea un nuevo elemento compra con el detalle necesario
            //       (ID auto - incremental, Comprador = ID_Usuario, Productos copiando los
            //       elementos del carrito a un nuevo diccionario(¡cuidado con las referencias!)
            //       y el total según calculado).

            //Disminuye el stock de los productos según lo comprado por el usuario. 

            //Luego vacía el carrito del usuario. 

            //Muestra el resultado por pantalla(ToString de la compra recientemente creada) 
            //       y devuelve el valor correspondiente indicando si la ejecución fue correcta.


            return true;
        }

        public bool ModificarCompra(int ID, double Total)
        {

            //Solo se permite modificar el total en caso que haya un error de facturación.
            //El resto de los datos no pueden ser modificados.

            return true;
        }

        public bool EliminarCompra(int ID)
        {
            // Nuestro “botón de arrepentimiento”…

            return true;
        }

        public void MostrarTodosLosProductosPorPrecio()
        {


            // Muestra todos los productos del mercado ordenados por precio.
        }

        public void MostrarTodosLosProductosPorCategoria()
        {
            //Muestra todas las categorías del mercado y para cada una de ellas 
            //    los productos dentro de la misma.
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
                Console.WriteLine(this.productos[i].ToString());
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
