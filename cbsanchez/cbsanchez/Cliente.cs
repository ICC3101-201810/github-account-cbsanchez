﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Cliente
    { // asumimos que cada cliente tiene solo autorizacion para manejar un vehiculo
        String nombre, rut;
        public Cliente(String minombre, String mirut)
        {
            nombre = minombre;
            rut = mirut;
        }
        public String Getrut()
        {
            return rut;
        }
    }
}

