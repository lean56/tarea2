﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaGenero.Entidades
{
    public class Genero
    {
            [Key]
            public int GeneroId { get; set; }
            public string Nombre { get; set; }
        
    }
}
