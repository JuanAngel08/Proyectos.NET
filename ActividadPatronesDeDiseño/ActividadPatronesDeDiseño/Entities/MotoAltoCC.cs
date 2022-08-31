using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesDeDiseño.Entities
{
    internal class MotoAltoCC : Entity
    {

        public  bool ABSEnCurva { get; private set; }
        public MotoAltoCC(int id, bool aBSEnCurva) : base(id)
        {
            ABSEnCurva = aBSEnCurva;
        }
    }
}
