using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    class Vehiculo
    {
        string tipo;
        string modelo;
        int precio;
        string licenciareq;
        int stock;

        public Vehiculo(string tipo,string modelo, int precio, string licenciareq, int stock)
        {
            this.tipo = tipo;
            this.modelo = modelo;
            this.precio = precio;
            this.licenciareq = licenciareq;
            this.stock = stock;
        }
    }