﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Url_imagen { get; set; }
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }

    }
}
