using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
    {
    class Sucursal
    {
        public string nombresuc;
        int stockmax;
        Vehiculo[] catalogo;
        
        public Sucursal(string nombresuc,int stockmax, catalogo)
        {
            this.nombresuc = nombresuc;
            this.stockmax = stockmax;
            catalogo = new Vehiculo[stockmax];
          
        }
        public bool AgregarVehiculo(Vehiculo vehiculo,Sucursal sucursal)
        {
            if (stockmax > 0)
            {
                int posicionCar= catalogo.Length - stockmax;
                catalogo[posicionCar] = vehiculo;
                stockmax--;
                return true;
            }
            else return false;
        }

        }
       
 }   
