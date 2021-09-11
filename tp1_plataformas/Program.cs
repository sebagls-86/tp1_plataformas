using System;
namespace tp1_plataformas
{
    class Program
    {
        static void Main(string[] args)
        {

            Mercado mercado = new Mercado();
            string selector, loop;

            do
            {
                Console.WriteLine("Por favor ingrese una opción para continuar: \nPara administrar ingrese 1 \nPara comprar ingrese 2 \nPara salir presione otra tecla");
                selector = Console.ReadLine();


                if (selector == "1")
                {

                    Console.WriteLine("Seleccione una opción\r\n");

                    Console.WriteLine("1) Alta de categoría\r\n" +
                                      "2) Baja de categoría\r\n" +
                                      "3) Modificación de categoría\r\n" +
                                      "4) Mostrar categorías que existen en el sistema\r\n" +
                                      "5) Alta de usuario\r\n" +
                                      "6) Baja de usuario\r\n" +
                                      "7) Modificación de usuario\r\n" +
                                      "8) Mostrar usuarios que existen en el sistema\r\n" +
                                      "9) Alta de producto\r\n" +
                                      "10) Baja de producto\r\n" +
                                      "11) Modificación de producto\r\n" +
                                      "12) Mostrar productos que existen en el sistema\r\n" +
                                      "13) Mostrar productos que existen en el sistema ordenados por precio\r\n" +
                                      "14) Mostrar productos que existen en el sistema ordenados por categoría\r\n");

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {


                        case 1:
                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Alta de categoría'\r\n" +
                                                      "Ingrese el nombre de la categoría que desea crear");

                                string categoria = Convert.ToString(Console.ReadLine());
                                mercado.AgregarCategoria(categoria);

                                Console.WriteLine("¿Quiere ingresar una nueva categoría?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");

                            break;




                        case 2:

                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Baja de categoria'\r\n" +
                                                  "Ingrese el ID de la categoría que desea eliminar");

                                int id = Convert.ToInt32(Console.ReadLine());

                                bool existeCat = mercado.ExisteCategoriaPorId(id);

                                if (existeCat)
                                {
                                    mercado.EliminarCategoria(id);
                                    mercado.MostrarCategorias();
                                }
                                else
                                {
                                    Console.WriteLine("Categoria inexistente");
                                }

                                Console.WriteLine("¿Quiere eliminar otra categoria?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");
                            break;


                        case 3:
                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Modificar categoría'\r\n" +
                                                  "Ingrese el ID y el nombre de la categoría que desea modificar");


                                int idCategiriaModificar = Convert.ToInt32(Console.ReadLine());
                                string categoriaModificar = Convert.ToString(Console.ReadLine());

                                int idCat = Convert.ToInt32(Console.ReadLine());

                                bool existeCatMod = mercado.ExisteUsuarioPorId(idCat);

                                if (existeCatMod)
                                {
                                    mercado.ModificarCategoria(idCategiriaModificar, categoriaModificar);
                                    mercado.MostrarCategorias();
                                }
                                else
                                {
                                    Console.WriteLine("Categoria inexistente");
                                }



                                Console.WriteLine("¿Quiere modificar otra categoria?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");

                            break;


                        case 4:
                            Console.WriteLine("Ha seleccionado 'Mostrar categorías que existen en el sistema'\r\n");

                            mercado.MostrarCategorias();
                            break;

                        case 5:

                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Alta de usuario'\r\n");

                                Console.WriteLine("Ingrese el DNI del usuario sin espacios\r\n");
                                int dni = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el nombre del usuario\r\n");
                                string nombre = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingrese el apellido del usuario\r\n");
                                string apellido = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingrese el mail del usuario\r\n");
                                string mail = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingrese la contraseña del usuario\r\n");
                                string password = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingrese el CUIL del usuario sin espacios\r\n");
                                int cuil = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("¿Es una empresa?\r\n" +
                                                  "Ingrese 1 si es correcto, sino un 0");

                                bool esEmpresa = true;
                                int empresa = 0;

                                do
                                {
                                    empresa = Convert.ToInt32(Console.ReadLine());
                                }
                                while (empresa != 1 && empresa != 0);

                                if (empresa == 0)
                                {
                                    esEmpresa = false;
                                }

                                mercado.AgregarUsuario(dni, nombre, apellido, mail, password, cuil, esEmpresa);


                                Console.WriteLine("¿Quiere dar de alta a otro usuario?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");


                            break;

                        case 6:

                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Baja de usuario'\r\n" +
                                                  "Ingrese el ID del usuario a eliminar");

                                int idBajaUsuario = Convert.ToInt32(Console.ReadLine());
                                mercado.EliminarUsuario(idBajaUsuario);

                                Console.WriteLine("¿Quiere eliminar a otro usuario?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");

                            break;

                        case 7:

                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Modificar usuario'\r\n" +
                                               "Ingrese el ID del usuario a modificar");

                                mercado.AgregarUsuario(35, "1", "Apellido", "Mail", "Passord", 35, true);
                                mercado.AgregarUsuario(35, "2", "Apellido", "Mail", "Passord", 35, true);
                                mercado.MostrarUsuarios();

                                int idUsuarioEditar = Convert.ToInt32(Console.ReadLine());

                                bool existe = mercado.ExisteUsuarioPorId(idUsuarioEditar);

                                if (existe)
                                {

                                    Console.WriteLine("¿Es una empresa?\r\n" +
                                              "Ingrese 1 si es correcto, sino un 0");

                                    bool esEmpresaModificar = true;
                                    int empresaModificar;
                                    do
                                    {
                                        empresaModificar = Convert.ToInt32(Console.ReadLine());
                                    }
                                    while (empresaModificar != 1 && empresaModificar != 0);

                                    if (empresaModificar == 0)
                                    {
                                        esEmpresaModificar = false;
                                    }


                                    Console.WriteLine("Ingrese el DNI del usuario sin espacios\r\n");
                                    int dniModificar = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese el nombre del usuario\r\n");
                                    string nombreModificar = Convert.ToString(Console.ReadLine());

                                    Console.WriteLine("Ingrese el apellido del usuario\r\n");
                                    string apellidoModificar = Convert.ToString(Console.ReadLine());

                                    Console.WriteLine("Ingrese el mail del usuario\r\n");
                                    string mailModificar = Convert.ToString(Console.ReadLine());

                                    Console.WriteLine("Ingrese la contraseña del usuario\r\n");
                                    string passwordModificar = Convert.ToString(Console.ReadLine());

                                    Console.WriteLine("Ingrese el CUIL/CUIT del usuario sin espacios\r\n");
                                    int cuilModificar = Convert.ToInt32(Console.ReadLine());


                                    mercado.ModificarUsuario(idUsuarioEditar, dniModificar, nombreModificar, apellidoModificar, mailModificar, passwordModificar, cuilModificar, esEmpresaModificar);

                                }
                                else
                                {
                                    Console.WriteLine("Usuario inexistente");
                                }

                                Console.WriteLine("¿Quiere modificar a otro usuario?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");

                            break;


                        case 8:
                            Console.WriteLine("Ha seleccionado 'Mostrar usuarios'\r\n");

                            mercado.MostrarUsuarios();
                            break;


                        case 9:

                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Alta de producto'\r\n");

                                Console.WriteLine("Ingrese el nombre del producto\r\n");
                                string nombreProducto = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingrese el precio del producto\r\n");
                                double precioProducto = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Ingrese la cantidad del producto\r\n");
                                int cantidadProducto = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el ID de la categoría del producto\r\n");
                                int idCategoriaProducto = Convert.ToInt32(Console.ReadLine());


                                mercado.AgregarProducto(nombreProducto, precioProducto, cantidadProducto, idCategoriaProducto);

                                Console.WriteLine("¿Quiere dar de alta otro producto?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");
                            break;


                        case 10:
                            do
                            {
                                Console.WriteLine("Ha seleccionado 'Baja de producto'\r\n" +
                                                  "Por favor, ingrese el ID del producto que desea eliminar\r\n");

                                int idProductoEliminar = Convert.ToInt32(Console.ReadLine());
                                mercado.EliminarProducto(idProductoEliminar);

                                Console.WriteLine("¿Quiere eliminar otro producto?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");
                            break;

                        case 11:
                            do
                            {

                                Console.WriteLine("Ha seleccionado 'Modificar producto'\r\n" +
                                                        "Ingrese el ID del usuario a modificar");

                                mercado.AgregarCategoria("Categoria");
                                mercado.AgregarProducto("Producto", 30, 1, 1);
                                mercado.MostrarProductoEnPantalla();


                                int idProductoEditar = Convert.ToInt32(Console.ReadLine());

                                bool existeProducto = mercado.ExisteProductoPorId(idProductoEditar);

                                if (existeProducto)
                                {

                                    Console.WriteLine("Ingrese el nombre del producto\r\n");
                                    string nombreProductoModificar = Convert.ToString(Console.ReadLine());

                                    Console.WriteLine("Ingrese el precio del producto\r\n");
                                    double precioProductoModificar = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Ingrese la cantidad del producto\r\n");
                                    int cantidadProductoModificar = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese el ID de la categoría del producto\r\n");
                                    int idCategoriaProductoModificar = Convert.ToInt32(Console.ReadLine());

                                    mercado.ModificarProducto(idProductoEditar, nombreProductoModificar, precioProductoModificar, cantidadProductoModificar, idCategoriaProductoModificar);

                                    mercado.MostrarProductoEnPantalla();
                                }
                                else
                                {
                                    Console.WriteLine("Producto inexistente");

                                }
                                Console.WriteLine("¿Quiere modificar otro producto?\n Ingrese 1 para Si \nPresione cualquier tecla para No");
                                loop = Console.ReadLine();

                            } while (loop == "1");
                            break;


                        case 12:
                            Console.WriteLine("Ha seleccionado la opción 12, a continuación el detalle de productos en sistema:\r\n");
                            mercado.MostrarProductoEnPantalla();
                            break;


                        case 13:
                            Console.WriteLine("Ha seleccionado la opción 13, a continuación el detalle de productos ordenado por precio:\r\n");
                            mercado.MostrarTodosLosProductosPorPrecio();
                            break;


                        case 14:

                            Console.WriteLine("Ha seleccionado la opción 14, a continuación el detalle de productos ordenado por categoria:\r\n");
                            mercado.MostrarTodosLosProductosPorCategoria();


                            break;

                    }

                }
                else if (selector == "2")

                {
                    Console.WriteLine("Bajo construcción, próximamente en TP-2");
                }


            } while (selector == "1" || selector == "2");

            if (selector != "1" && selector != "2")
            {
                Console.WriteLine("El programa se cerrará");

            }


        }
    }
}
