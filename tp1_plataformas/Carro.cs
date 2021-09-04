using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Carro
        
     {

        int id;
        

       Dictionary<Producto, int> productos = new Dictionary<Producto, int>();
    

    public void agregarProducto(Producto P, int Cantidad)
    {

    }

    public void quitarProducto(Producto P, int Cantidad)
    {

    }

    public void vaciar()
    {

    }

        public override string ToString()
        {
            return $"{this.id}, {" - "}, {this.productos}";
        }
    }
}
