using ActInterfacez.Accesorios;
using ActInterfacez.PiezasTapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.Motos
{
    internal class Moto
    {
        private IAccesorios Accesorio; //Agregacion
        private PiezasTapa TapaLateral; //Composicion



        public Moto(IAccesorios accesorio)
        {
            Accesorio = accesorio;  //Agregacion
            this.TapaLateral = new TapaLateral("20x35","32"); //Composicion  (Cada vez que se cree una moto automaticamente se crea una nueva pieza)
        }
    }
}
