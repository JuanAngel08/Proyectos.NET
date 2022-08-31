using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfacez.PiezasTapas
{
    internal abstract  class PiezasTapa
    {


        public string TamañoPiezas { get; protected set; }  //Atributos de piezas tapas
        public string CantidadTornillos { get; protected set; }  //Atributos de piezas tapas


        protected PiezasTapa(string tamañoPiezas, string cantidadTornillos)   //Constructor de piezas tapas
        {
            TamañoPiezas = tamañoPiezas;
            CantidadTornillos = cantidadTornillos;
        }



        public void Ensamblar()   //Metodo de piezas tapas
        {
            Console.WriteLine("Usar Tornilleria");
    }

        public abstract void ColorTapas();   //Metodo abstracto de piezas tapas  - es abstracto ya que puede variar entre clases
    }
}
