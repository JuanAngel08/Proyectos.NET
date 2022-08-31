using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.Accesorios
{
    internal class ProtectorLiquidoFrenoDelantero : IAccesorios
    {
        public void Agregar()
        {
            Console.WriteLine("Se agrea el protector del freno delantero");
        }
    }
}
