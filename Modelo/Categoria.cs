﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString() => Descripcion;
    }
}
