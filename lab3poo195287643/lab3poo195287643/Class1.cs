using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    public class Arriendo
    {
        public List<Sucursal> sucursales;
        public List<Cliente> clientes;

        public Arriendo()
        {
            sucursales = new List<Sucursal>();
            clientes = new List<Cliente>();
        }
        public void Agregarclientes(Cliente cliente)
        {
            clientes.Add(cliente);
        }
        public void Agregarsucursales(Sucursal sucursal)
        {
            sucursales.Add(sucursal);
        }

    }
}
