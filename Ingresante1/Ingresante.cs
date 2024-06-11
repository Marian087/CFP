using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingresante1
{
    public class Ingresante
    {
        string nombre;
        string apellido;
        int edad;
        string genero;
        string pais;
        List<string> cursos;

       

        public Ingresante(string nombre, string apellido, int edad, string genero, string pais, List<string> cursos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }


        //public Ingresante(string nombre, string apellido, int edad, string genero, string pais, string cursos)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.edad = edad;
        //    this.genero = genero;
        //    this.pais = pais;
        //    this.cursos = cursos;
        //}
        public string nombre { get => nombre; }
        public string apellido { get => apellido; }
        public int edad { get => edad; }
        public string generoa { get => genero; }




        public string Cursos //string builder
        {
            get 
            {
                StringBuilder sb = new StringBuilder();

                for (int i =0; i< cursos.Count(); i++) 
                {
                    sb.Append(cursos[i]); // no produce un salto de linea

                    if (i< cursos.Count - 1) 
                    {
                        sb.Append(" - ");
                       
                    
                    
                    }

                
                }
                return sb.ToString();
            
            }
        
        
        }


    }
}
