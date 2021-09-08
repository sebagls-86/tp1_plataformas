using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Empresa: Usuario
    {
        public int Cuil { get; set; }

        public Empresa(int id, int dni, String nombre, String apellido, String mail, String password,Carro carro, int cuil) : base(id, dni, nombre, apellido, mail, password, carro)
        {
            Cuil = cuil;
        }

        public override string ToString()
        {
            return $"{this.Cuil}";
        }
    }
}
