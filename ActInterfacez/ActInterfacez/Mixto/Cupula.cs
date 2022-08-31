using ActInterfacez.PiezasTapas;
using ActInterfacez.Accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.Mixto
{
    internal class Cupula : PiezasTapa , IAccesorios
    {
        public Cupula(string tamañoPiezas, string cantidadTornillos) : base(tamañoPiezas, cantidadTornillos)
        {
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public override void ColorTapas()
        {
            throw new NotImplementedException();
        }
    }
}
