using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.PiezasTapas
{
    internal class TapaLateral : PiezasTapa
    {

        public TapaLateral(string tamañoPiezas, string cantidadTornillos) : base(tamañoPiezas, cantidadTornillos) // se agrega el constructor para obtener los atributos de la herencia en este caso de PiezasTapas
        {
        }

        public override void ColorTapas()
        {
           Console.WriteLine("Las dos tapas laterales en su gran mayoria deben llevar los mismos colores para generar uniformidad");
        }
    }
}
