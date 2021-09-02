using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Categoria
    {
        int id;
        string nombre;

        public Categoria()
        {
        }

        public override string ToString()
        {
            return $"{this.id}, {" - "}, {this.nombre}";
        }
    }
}
