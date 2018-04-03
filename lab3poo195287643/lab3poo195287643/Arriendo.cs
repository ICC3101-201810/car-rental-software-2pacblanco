using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    class Arriendo
    {
        public class Accesorios : Arriendo
        {
            string tipo;
            int precio;

            public Accesorios(string tipo,int precio) :base()
            {
                this.tipo = tipo;
                this.precio = precio;

            }
        }
    }     
}
