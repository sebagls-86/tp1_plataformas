using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Categoria
    {
        int id;
        string nombre;

        public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int getIdCategoria()
        {
            return this.id;
        }

        public int setIdCategoria()
        {
            this.id = this.id + 1;
            return this.id;
        }

        public override string ToString()
        {
            return $"{this.id}, {" - "}, {this.nombre}";
        }
    }
}
