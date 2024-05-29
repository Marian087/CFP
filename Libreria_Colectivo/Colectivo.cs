using System.Runtime.CompilerServices;

namespace Libreria_Colectivo
{
    public class Colectivo
    {
        //atributos

        private string patente;
        private int linea;
        private string empresa;
        private int capacidad;
        private int cantPasajeros;
        private string cabecera;
        private string terminal;

        //constructor

        public Colectivo(string patente, int linea, string empresa, int capacidad, int cantPasajeros, string cabecera, string terminal) 
        {
            this.patente = patente;
            this.linea = linea;
            this.empresa = empresa;
            this.capacidad = capacidad;
            this.cantPasajeros = cantPasajeros;
            this.cabecera = cabecera;
            this.terminal = terminal;
                   
        
        }
        //metodos Get - son los que no van a modificarse.
        public string GetPatente() 
        {
            return patente;
        
        }
        public int Getlinea()
        {
            return linea;

        }
        public string Getempresa()
        {
            return empresa;

        }

        //metodos set - son los que pueden modificarse.
        //public void SetCapacidad( int capacidad)
        //{
        //    capacidad =;

        //}
        public int GetcantPasajeros()
        {
            return cantPasajeros;

        }
        public void SetCabecera( string destino)            
        {
            cabecera= destino;

        }
        public void SetTerminal( string destino)
        {
            terminal = destino;

        }

        public string ColectivoToString() 
        {
            return $"Patente: {patente} - Linea:{linea} - Empresa: {empresa} - Capacidad: {capacidad} - Cabecera:{cabecera}- Terminal: {terminal}- Cantidad de Pasajeros: {cantPasajeros}"


        }

        public bool SubirPasajeros(int cantidad) 
        {
            bool puedenSubir = false;

            if((this.capacidad> this.cantPasajeros)&& (this.cantPasajeros + cantidad <= capacidad)) 
            {
                this.cantPasajeros <= cantidad;
                puedenSubir = true;
            
            
            }
        
        }

        public static int CompararColectictivosPorLinea(Colectivo c1, Colectivo c2) 
        {
            return c1.Getlinea() c2.Getlinea();
        
        }

        public static int CompararColectivosPorLinea(Colectivo c1, Colectivo c2)
        {
            int resultado = 0;

            //metodo de comparaciòn if//

            if (c1.Getlinea() < c2.Getlinea())
            {
                resultado = -1;

            }
            else
            {
                if (c1.Getlinea() > c2.Getlinea())
                {
                    resultado = 1;

                }

            }



        }




    }
}
