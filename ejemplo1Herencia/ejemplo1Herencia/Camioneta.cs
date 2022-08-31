using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1Herencia
{
    internal class Camioneta : VehiculoEmpresarial
    {
        public string TipoBlindaje { get; private set; }
        public Camioneta(string CilindrajeVehiculo, string PlacaVehiculo, string LineaVehiculo, string MarcaVehiculo, string tipoBlindaje) : base(CilindrajeVehiculo, PlacaVehiculo, LineaVehiculo, MarcaVehiculo)
        {
            TipoBlindaje = tipoBlindaje;
        }
    }
}
