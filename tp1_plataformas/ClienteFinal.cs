using System;

namespace tp1_plataformas
{
    class ClienteFinal : Usuario
    {

        public int Cuil { get; set; }


        public ClienteFinal(int id, int dni, String nombre, String apellido, String mail, String password, Carro carro, int cuil) : base(id, dni, nombre, apellido, mail, password, carro)
        {
            Cuil = cuil;
        }



        public override string ToString()
        {

            return $"{Id} {"-"} {Nombre} {"-"} {Apellido} {"-"} {Mail}" +
                $"{"-"} {Password} {"-"} {Cuil}";

        }
    }
}
