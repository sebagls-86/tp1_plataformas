using System;
using System.Collections.Generic;

namespace tp1_plataformas
{
    public class Carro
    {

        public int Id { get; set; }
        public Dictionary<Producto, int> Productos { get; set; }

        public Carro(int _id, Producto producto, int cantidad)
        {
            Id = _id;
            Productos = new Dictionary<Producto, int>();
            Productos.Add(producto, cantidad);
        }

        public Carro(int id)
        {
            Id = id;
            Productos = new Dictionary<Producto, int>();
        }

        public bool AgregarProducto(Producto p, int cantidad)
        {
            bool seAgregoElProducto = false;
            if (p == null)
            {
                Console.WriteLine("Producto nulo. Debe ir una excepcion aca.");
                seAgregoElProducto = false;
            }
            else if (cantidad <= 0)
            {
                Console.WriteLine("Cantidad menor o igual a 0. Debe ir una excepcion aca.");
                seAgregoElProducto = false;
            }
            else if (Productos.ContainsKey(p))
            {
                Productos[p] += 1;
                seAgregoElProducto = true;
            }
            else
            {
                Productos[p] = cantidad;
                seAgregoElProducto = true;
            }
            return seAgregoElProducto;
        }


        public bool RemoverProducto(Producto p, int cantidad)
        {
            bool seQuitoElProducto = false;
            if (p == null)
            {
                Console.WriteLine("Producto nulo. Debe ir una excepcion aca.");
                seQuitoElProducto = false;
            }
            else if (cantidad < 0)
            {
                Console.WriteLine("Cantidad menor a 0. Debe ir una excepcion aca.");
                seQuitoElProducto = false;
            }
            else if (Productos.ContainsKey(p))
            {
                if (cantidad > Productos[p] || cantidad == 0)
                {
                    Productos.Remove(p);
                    seQuitoElProducto = true;
                }
                else
                {
                    Productos[p] = Productos[p] - cantidad;
                    seQuitoElProducto = true;
                }

            }
            else
            {
                Console.WriteLine("El producto que quiere disminuir no existe en la lista, agreguelo para poder realizar esta operacion.");
                seQuitoElProducto = false;
            }
            return seQuitoElProducto;
        }

        public bool Vaciar()
        {
            bool seVacio = false;
            if (Productos.Count > 0)
            {
                Productos.Clear();
                Console.WriteLine("Se vació la lista exitosamente.");
                seVacio = true;
            }
            else
            {
                Console.WriteLine("La lista de productos está vacia.");
            }
            return seVacio;
        }

        public override string ToString()
        {
            return $"{Id} {"-"} {Productos}";
        }
    }
}
