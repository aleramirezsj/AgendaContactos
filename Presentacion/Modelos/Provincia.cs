﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public RegionEnum Region { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
