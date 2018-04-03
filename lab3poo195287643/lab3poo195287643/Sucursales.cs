using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    class Sucursal
    {
        string nombresuc;
        int stockmax;
        List<Vehiculo> catalogo = new List<Vehiculo>();
        
        public Sucursal(string nombresuc,int stockmax, List<Vehiculo> catalogo)
        {
            this.nombresuc = nombresuc;
            this.stockmax = stockmax;
            this.catalogo = catalogo;
          
        }
        public void AgregarVehiculo(Vehiculo vehiculo,Sucursal sucursal)
        {
            while (sucursal.stockmax > 0)
            {
                catalogo.Add(vehiculo);
                sucursal.stockmax = (sucursal.stockmax - 1);
                
            }
        }
       
    }
}
