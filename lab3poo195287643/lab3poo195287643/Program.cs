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
            Arriendo a = new Arriendo();
            Vehiculo.Auto v1 = new Vehiculo.Auto("B", "hkhv26", "Celerio",2016);
            Sucursal suc = new Sucursal("Fontova",5);
            Cliente.Persona p1= new Cliente.Persona("Si","b","195287643","johnny donoso","19");

            suc.AgregarAuto(v1);

            a.Agregarclientes(p1);
            a.Agregarsucursales(suc);

            
            Console.WriteLine("Buenas tardes Usuario. \nEsta Aplicación arrienda Recibe y Arrienda vehiculos, ingrese su opción a continuación: \n");
            Console.WriteLine("1.- ARRENDAR VEHICULO \n ");
            Console.WriteLine("2.- RECIBIR VEHICULO \n ");
            string x;
            x= Console.ReadLine();
            int l= int.Parse(x);

            if(l==1)
            {
                Console.Write("Ingrese Nombre sucursal donde se encuentra su vehiculo deseado: \n");
                string sucursalita= Console.ReadLine();
                foreach(Sucursal c in a.sucursales)
                {
                    if (c.nombresuc == sucursalita)
                    {
                        Console.Write("Ingrese el modelo de el auto requerido: \n");
                        string modelo1= Console.ReadLine();
                        foreach(Vehiculo car in c.Getcatalogo)
                        {
                            if (car.modelo== modelo1)  
                            {

                            }                               
                        }

                    }
                    else
                    {
                        Console.Write("Sucursal no existe");
                        break;
                    }
                }
                

            }
        
      

        Console.ReadKey();  
        }
 
        

        
    }
}
