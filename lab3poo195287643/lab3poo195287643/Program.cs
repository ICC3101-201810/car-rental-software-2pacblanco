using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo.Auto v1 = new Vehiculo.Auto("B", "hkhv26", "Celerio",2016);
            Sucursal suc = new Sucursal("Fontova", 5,catalogo);
            Cliente.Persona p1= new Cliente.Persona("Si","b","195287643","johnny donoso","19");

            registro.ObtenerRegistroArriendo(suc,p1,v1);
            Console.ReadKey();
        }
    }
}
