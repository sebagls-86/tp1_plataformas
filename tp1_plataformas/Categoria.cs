using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria(int _id, string _nombre)
        {
            Id = _id;
            Nombre = _nombre;
        }

        public override string ToString()
        {
            return $"{Id} {"-"} {Nombre}";
        }
    }
}
