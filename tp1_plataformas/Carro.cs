using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Carro {

        public int Id { get; set; }
        Dictionary<Producto, int> Productos { get; set; }

        public Carro(int _id, Producto producto, int cantidad)
        {
            Id = _id;
            Productos = new Dictionary<Producto, int>();
            Productos.Add(producto, cantidad);
        }


        public void AgregarProducto(Producto p, int cantidad) {

        }

        public void QuitarProducto(Producto p, int cantidad)
        {

        }

        public void Vaciar()
        {

        }

        public override string ToString()
        {
            return $"{this.Id}, {" - "}, {this.Productos}";
        }
    }
}
