using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria(int _id, string _nombre)
        {
            this.Id = _id;
            this.Nombre = _nombre;
        }

        public override string ToString()
        {
            return $"{this.Id}, {" - "}, {this.Nombre}";
        }
    }
}
