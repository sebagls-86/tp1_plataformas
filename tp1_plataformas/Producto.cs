using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Double Precio { get; set; }
        public int Cantidad { get; set; }
        Categoria Cat;

        public Producto(int Id, string Nombre, Double Precio, int Cantidad, Categoria Cat)
        {
        }

        public override string ToString()
        {
            return $"{this.Id},{" - "}, {this.Nombre}, {" - "}, {this.Precio}" +
                $"{this.Cantidad}, {" - "}, {this.Cat}";
        }
    }
}
