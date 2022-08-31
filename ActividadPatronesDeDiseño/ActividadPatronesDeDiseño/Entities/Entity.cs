﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesDeDiseño.Entities
{
    internal abstract class Entity
    {

        public int Id { get; set; }

        protected Entity (int id)
        {
            Id = id;
        }
    }
}
