using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    class registro
    {
       Sucursal sucursal;
       Vehiculo vehiculo;
       Cliente cliente;

        public registro(Sucursal sucursal, Cliente cliente, Vehiculo vehiculo)
        {
            this.sucursal= sucursal;
            this.cliente= cliente;
            this.vehiculo= vechiculo;
        }

        public virtual void ObtenerRegistroArriendo(Sucursal sucursal, Cliente cliente,Vehiculo vehiculo)
        {
            Console.WriteLine("Su registro de arriendo es el sgte: Don(a)" + cliente.nombre + "arrendo el modelo" + vehiculo.modelo + "con un precio de "+vehiculo.precio+ "en la sucursal "+sucursal.nombresuc+"con fecha"+DateTime.Now()+"y termino en 3 meses mas");
        }
    }
    }

