using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    public class Cliente
    {
        string rut;
        string nombre;
        string edad;

        public Cliente(string rut,string nombre,string edad)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.edad = edad;
        }
        public class Persona : Cliente
        {
            string Licencia;
            string tipo;

            public Persona(string Licencia,string tipo,string rut, string nombre, string edad):base(rut, nombre, edad)
            {
                this.Licencia = Licencia;
                this.tipo = tipo; 
            }
        }
        public class Empresa: Cliente
        {
            string autorizacion;
            string tipo;
            public Empresa(string autorizacion,string tipo,string rut, string nombre,string edad):base(rut, nombre,edad)
            {
                this.autorizacion = autorizacion;
                this.tipo = tipo;
            }
        }
    }   

    
}
