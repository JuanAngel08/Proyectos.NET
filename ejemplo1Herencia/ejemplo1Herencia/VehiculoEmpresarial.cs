using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1Herencia
{
    internal class VehiculoEmpresarial
    {
        public string MarcaVehiculo { get; protected set; }
        public string CilindrajeVehiculo { get; protected set; }
        public string PlacaVehiculo { get; protected set; }
        public string LineaVehiculo { get; protected set; }



        protected VehiculoEmpresarial(string CilindrajeVehiculo, string PlacaVehiculo, string LineaVehiculo, string MarcaVehiculo)
        {
            this.CilindrajeVehiculo = CilindrajeVehiculo;
            this.PlacaVehiculo = PlacaVehiculo;
            this.LineaVehiculo = LineaVehiculo;
            this.MarcaVehiculo = MarcaVehiculo;
        }
        
   
    }

   
}
