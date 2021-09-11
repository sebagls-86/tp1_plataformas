using System;

namespace tp1_plataformas
{
    class Empresa : Usuario
    {
        public int Cuit { get; set; }

        public Empresa(int id, int dni, String nombre, String apellido, String mail, String password, Carro carro, int cuil) : base(id, dni, nombre, apellido, mail, password, carro)
        {
            Cuit = cuil;
        }

        public override string ToString()
        {
            return $"{Id} {"-"} {Nombre} {"-"} {Apellido} {"-"} {Mail}" +
                $"{"-"} {Password} {"-"} {Cuit}";
        }
    }
}
