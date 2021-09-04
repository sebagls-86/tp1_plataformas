using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Producto
    {

        int id { get; set; }
        string nombre { get; set; }
        Double precio { get; set; }
        int Cantidad { get; set; }
        Categoria cat { get; set; }

        public Producto(string nombre, double precio, int Cantidad, int idCategoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.Cantidad = Cantidad;
            this.cat = cat;
        }

        public Producto()
        {

        }
        
        public Producto(int id, string nombre, double precio, int cantidad, int idCategoria) //Carga manual
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            Cantidad = cantidad;
        }

        public int getIdProducto()
        {
            return this.id;
        }

        public int setIdProducto()
        {
            this.id = this.id + 1;
            return this.id;
        }
        public override string ToString()
        {

            return $"{this.id},{" - "}, {this.nombre}, {" - "}, {this.precio}, {this.Cantidad}, {" - "}, {this.cat}";
            //return $"{this.id},{" - "}, {this.nombre}, {" - "}, {this.precio}" +
            //    $"{this.Cantidad}, {" - "}, {this.cat}";
        }
    }
}
