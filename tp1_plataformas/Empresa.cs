using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Empresa: Usuario
    {
        int cuil;

        public Empresa(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return $"{this.cuil}";
        }
    }
}
