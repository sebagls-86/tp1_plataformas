using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Carro {

        public int Id { get; set; }
        Dictionary<Producto, int> Productos { get; set; }
    
        public Carro(int _id, Producto producto, int cantidad) { 
            Id = _id;
            Productos = new Dictionary<Producto, int>() { producto, cantidad }
        }


        public void agregarProducto(Producto p, int cantidad) {

        }

        public void quitarProducto(Producto p, int cantidad) {

        }

        public void vaciar()  {

        }

        public override string ToString()
        {
            return $"{this.id}, {" - "}, {this.productos}";
        }
    }
}
