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
    }
}
