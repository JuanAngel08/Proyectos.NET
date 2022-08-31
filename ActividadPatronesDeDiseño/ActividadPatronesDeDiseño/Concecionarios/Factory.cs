using ActividadPatronesDeDiseño.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesDeDiseño.Concecionarios
{
    internal class Factory : IFactory

    {
        public Entity BuildMotoAltoCC(int id, bool aBSEnCurva)
        {
            return new MotoAltoCC(id, aBSEnCurva);
        }

        public Entity BuildMotoBajoCC(int id)
        {
            return new MotoBajoCC(id);
        }
    }
}
