using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    public abstract class Usuario
    {

        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public Carro MiCarro { get; set; }


        protected Usuario(int id, int dni, string nombre, string apellido, string mail, string password, Carro carro)
        {
            Id = id;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Password = password;
            MiCarro = carro;
        }

        public override string ToString()
        {
            return $"{Id} {"-"} {Dni}{"-"}{Nombre}{"-"}" +
                $"{Apellido} {"-"} {Mail} {"-"} {Password}" +
                $"{"-"} {MiCarro}";
        }
    }
}
