using System;
using System.Collections.Generic;
using System.Text;


namespace tp1_plataformas
{
    class Compra
    {
        public int Dni { get; set; }
        Usuario Comprador;
        Dictionary<Producto, int> Productos { get; set; }
        public Double Total { get; set; }

        public Compra(int dni, Usuario usuario, Producto producto, double total)
        {
        }

        public override string ToString()
        {
            return $"{Dni} {"-"} {Comprador} {"-"} {Productos} {"-"} {Total}";
        }
    }
}
