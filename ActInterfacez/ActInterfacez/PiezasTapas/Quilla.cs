using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.PiezasTapas
{
    internal class Quilla : PiezasTapa
    {

        public Quilla(string tamañoPiezas, string cantidadTornillos) : base(tamañoPiezas, cantidadTornillos)  // se agrega el constructor para obtener los atributos de la herencia en este caso de PiezasTapa
        {
        }

        public override void ColorTapas()
        {
            Console.WriteLine("El color de la quilla debe ser oscuro ya que esta expuesto a mas suciedad y rayones");
        }
    }
}
