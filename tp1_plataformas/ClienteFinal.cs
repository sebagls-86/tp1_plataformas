﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class ClienteFinal: Usuario
    {
        int cuil;

        public ClienteFinal(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return $"{this.cuil}";
        }
    }
}