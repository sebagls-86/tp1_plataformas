using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Producto
    {

        int id;
        string nombre;
        Double precio;
        int Cantidad;
        Categoria cat;

        public Producto()
        {
        }

        public override string ToString()
        {
            return $"{this.id},{" - "}, {this.nombre}, {" - "}, {this.precio}" +
                $"{this.Cantidad}, {" - "}, {this.cat}";
        }
    }
}
