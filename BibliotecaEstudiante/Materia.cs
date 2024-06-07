using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Alumno
{
    public class Materia
    {
        private string nombre;
        private int  duracion;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private Random= Random

        //constructores - boton derecho sobre materia crear constructores.
        public Materia(string nombre)
        {
            this.nombre = nombre;
          
        }
        public int CalcularNotaFinal() 
        {
        
        
        }



        //propertis
        public string Nombre { get => nombre;  }
        public int Duracion { get => duracion;  }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
    }
}
