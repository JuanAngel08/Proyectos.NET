using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1Herencia
{
    internal class Moto : VehiculoEmpresarial
    {
        public string TipoMoto { get; private set; }
        public Moto(string CilindrajeVehiculo, string PlacaVehiculo, string LineaVehiculo, string MarcaVehiculo, string tipoMoto) : base(CilindrajeVehiculo, PlacaVehiculo, LineaVehiculo, MarcaVehiculo)
        {
            TipoMoto = tipoMoto;
        }
    }
}
