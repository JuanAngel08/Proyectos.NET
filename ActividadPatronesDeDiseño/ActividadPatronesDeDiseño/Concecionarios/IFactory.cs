using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadPatronesDeDiseño.Entities;

namespace ActividadPatronesDeDiseño.Concecionarios
{
    internal interface IFactory
    {
        public Entity BuildMotoAltoCC(int id, bool aBSEnCurva);
        public Entity BuildMotoBajoCC(int id);

    }
}
