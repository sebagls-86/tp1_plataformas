using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    abstract class Usuario
    {

        int id;
        int dni;
        string nombre;
        string apellido;
        string mail;
        string password;
        Carro miCarro;

        protected Usuario(int id)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        internal Carro MiCarro { get => miCarro; set => miCarro = value; }

        public override string ToString()
        {
            return $"{this.Id}, {" - "},{this.Dni},{" - "},{this.Nombre},{" - "}," +
                $"{this.Apellido},{" - "},{this.Mail},{" - "},{this.Password}," +
                $"{" - "}, {this.MiCarro}";
        }


    }
}
