﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tp1_plataformas
{
    class Compra
    {
        int dni;
        Usuario comprador;
        Dictionary<Producto, Cantidad> productos = new Dictionary<Producto, Cantidad>();
        Double total;
    }
}
