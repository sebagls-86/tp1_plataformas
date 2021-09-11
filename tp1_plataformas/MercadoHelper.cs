using System.Collections.Generic;

namespace tp1_plataformas
{
    public abstract class MercadoHelper
    {

        public static bool SonMenoresACero(List<int> numeros) => numeros.Exists(numero => numero < 0);

        public static bool ExisteElUsuario(int idUsuario, List<Usuario> usuarios) => usuarios.Exists(usuario => usuario.Id == idUsuario);

        public static bool ExisteElProducto(int idProducto, List<Producto> productos) => productos.Exists(producto => producto.Id == idProducto);


    }
}
