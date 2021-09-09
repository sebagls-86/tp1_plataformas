using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    public class Producto : IComparable<Producto>
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Double Precio { get; set; }
        public int Cantidad { get; set; }
        public Categoria Cat { get; set; }

        public Producto(int Id, string Nombre, Double Precio, int Cantidad, Categoria Cat)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Cat = Cat;
        }

        public int CompareTo(Producto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }

        public override string ToString()
        {
            return $"{Id}{"-"} {Nombre} {"-"} {Precio} { "-"}" + 
                $"{Cantidad} {"-"} {Cat}";
        }
    }
}
