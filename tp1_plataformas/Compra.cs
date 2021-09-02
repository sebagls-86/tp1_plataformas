using System;
using System.Collections.Generic;
using System.Text;


namespace tp1_plataformas
{
    class Compra
    {
        int dni;
        Usuario comprador;
        Dictionary<Producto, int> productos = new Dictionary<Producto, int>();
        Double total;

        public Compra()
        {
        }

        public int Dni { get => dni; set => dni = value; }
        public double Total { get => total; set => total = value; }
        internal Usuario Comprador { get => comprador; set => comprador = value; }
        internal Dictionary<Producto, Cantidad> Productos { get => productos; set => productos = value; }

        public override string ToString()
        {
            return $"{this.Dni}, {" - "}, {this.Comprador}, {" - "}, {this.Productos}";
        }
    }
}
