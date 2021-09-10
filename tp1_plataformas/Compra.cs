using System;
using System.Collections.Generic;
using System.Text;


namespace tp1_plataformas
{
    class Compra : IComparable<Compra>
    {
        public int Id { get; set; }
        Usuario Comprador;
        Dictionary<Producto, int> Productos { get; set; }
        public Double Total { get; set; }

        public Compra(int Id, Usuario usuario, Producto producto, double total)
        {
        }

        public int CompareTo(Compra other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"{Id} {"-"} {Comprador} {"-"} {Productos} {"-"} {Total}";
        }
    }
}
