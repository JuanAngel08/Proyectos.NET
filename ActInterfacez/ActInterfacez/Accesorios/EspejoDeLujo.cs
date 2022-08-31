using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.Accesorios
{
    internal class EspejoDeLujo : IAccesorios
    {
        public void Agregar()
        {
            Console.WriteLine("Se agregan espejos de lujo");
        }
    }
}
