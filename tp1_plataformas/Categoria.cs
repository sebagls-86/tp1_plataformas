using System;

namespace tp1_plataformas
{
    public class Categoria : IComparable<Categoria>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }



        public Categoria(int _id, string _nombre)
        {
            Id = _id;
            Nombre = _nombre;
        }

        public int CompareTo(Categoria other)
        {
            return Nombre.CompareTo(other.Nombre);
        }

        public override string ToString()
        {
            return $"{Id} {"-"} {Nombre}";
        }
    }
}
