using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Categoria
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        //string nombre;
        public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"{this.id}, {" - "}, {this.nombre}";
        }
    }
}
