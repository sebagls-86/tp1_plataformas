using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    abstract class Usuario
    {

        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        Carro MiCarro;

        protected Usuario(int Id, int Dni, string Nombre, string Apellido, string Mail, string Password, Carro MiCarro)
        {

        }


        public override string ToString()
        {
            return $"{this.Id}, {" - "},{this.Dni},{" - "},{this.Nombre},{" - "}," +
                $"{this.Apellido},{" - "},{this.Mail},{" - "},{this.Password}," +
                $"{" - "}, {this.MiCarro}";
        }


    }
}
