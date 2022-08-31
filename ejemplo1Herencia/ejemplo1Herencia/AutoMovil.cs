using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1Herencia
{
    internal class AutoMovil : VehiculoEmpresarial

    {

        public string CapacidadVehiculo { get; private set; }
        public AutoMovil (string CilindrajeVehiculo, string PlacaVehiculo, string LineaVehiculo, string MarcaVehiculo, string CapacidadVehiculo) : base(CilindrajeVehiculo, PlacaVehiculo, LineaVehiculo, MarcaVehiculo)
        {

            CapacidadVehiculo = CapacidadVehiculo;
        }

        public void ImprimirValores()
        {
            Console.WriteLine("todos los vehiculos automovil no tienen mas de 5 puestos");
        }
    }
}
