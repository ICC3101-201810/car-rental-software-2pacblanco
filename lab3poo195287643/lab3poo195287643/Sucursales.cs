using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
    {
    public class Sucursal
    {
        public string nombresuc;
        int stockmax;
        Vehiculo[] catalogo;
     
        
        public Sucursal(string nombresuc,int stockmax)
        {
            this.nombresuc = nombresuc;
            this.stockmax = stockmax;
            catalogo= new Vehiculo[stockmax];
          
        }

        public bool AgregarAuto(Vehiculo vehiculo)
        {
            if (stockmax>0)
            {
                int posicionAuto=catalogo.Length-stockmax;
                catalogo[posicionAuto]= vehiculo;
                stockmax--;
                return true;
            }
            else return false;
        }
       
        
        public Vehiculo[] Getcatalogo()
        {
            return catalogo;
        }
       
 }}  
