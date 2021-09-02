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
            this.id = id;
        }

        public override string ToString()
        {
            return $"{this.id}, {" - "},{this.dni},{" - "},{this.nombre},{" - "}," +
                $"{this.apellido},{" - "},{this.mail},{" - "},{this.password}," +
                $"{" - "}, {this.miCarro}";
        }
    }
}
