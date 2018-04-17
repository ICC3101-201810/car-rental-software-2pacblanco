using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3poo195287643
{
    public class Vehiculo
    {
        public int precio;
        public string modelo;


        public Vehiculo(string modelo, int precio)
        {
            this.modelo = modelo;
            this.precio = precio;
        }

        public class Auto: Vehiculo
        {
            string licenciareq;
            public string patente;

            public Auto(string licenciareq,string patente, string modelo, int precio):base(modelo,precio)
            {
                this.licenciareq = licenciareq;
                this.patente= patente;
            }
        }   
         public class Acuatico: Vehiculo
        {
            string licenciareq;
            public string patente;

            public Acuatico(string licenciareq,string patente, string modelo, int precio):base(modelo,precio)
            {
                this.licenciareq = licenciareq;
                this.patente= patente;
            }
        }   
         public class Moto: Vehiculo
        {
            string licenciareq;
            public string patente;

            public Moto(string licenciareq,string patente, string modelo, int precio):base(modelo,precio)
            {
                this.licenciareq = licenciareq;
                this.patente= patente;
            }
        }
         public class Camion: Vehiculo
        {
            string licenciareq;
            public string patente;

            public Camion(string licenciareq,string patente, string modelo, int precio):base(modelo,precio)
            {
                this.licenciareq = licenciareq;
                this.patente= patente;
            }
         public class Bus: Vehiculo
        {
            string licenciareq;
            public string patente;

            public Bus(string licenciareq,string patente, string modelo, int precio):base(modelo,precio)
            {
                this.licenciareq = licenciareq;
                this.patente= patente;
            }
        }
       public class MaquinariaP: Vehiculo
        {
            string licenciareq;
            public string patente;
            string tipo;

            public MaquinariaP(string tipo, string licenciareq,string patente, string modelo, int precio):base(modelo,precio)
            {
                this.licenciareq = licenciareq;
                this.patente= patente;
                this.tipo=tipo; 
            }
        }}}}  