﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapacheBigoton.Class
{
    public class Service
    {
        public int IdServicio { get; set; }
        public int IdSucursal { get; set; }
        public string NombreServicio { get; set; }
        public string DescripcionServicio { get; set; }
        public decimal CostoServicio { get; set; }
    }
}
