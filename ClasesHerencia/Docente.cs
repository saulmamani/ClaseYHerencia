﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Docente : Usuario
    {
        /// <summary>
        /// Sueldo del docente modificado
        /// </summary>
        public decimal Sueldo { get; set; }

        public override string ToString()
        {
            return $"Cuenta: {Cuenta} | Password: {Password} | Nombre: {Nombre} | Sueldo: {Sueldo}";
        }
    }
}
