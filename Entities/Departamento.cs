﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contratos.Entities
{
    class Departamento
    {
        public string Nome { get; set; }

        public Departamento()
        {

        }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
