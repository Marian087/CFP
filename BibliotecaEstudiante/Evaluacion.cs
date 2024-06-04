using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Alumno
{
    public class Evaluacion
    {
        private Alumno alumno;
        private List <Materia> materias;
        private string carrera;

        
        private Evaluacion() 
        {
            this.materias = new List<Materia>();
            
        }

        public Evaluacion(Alumno alumno) :this()// inicializo a alumno
        {
            this.alumno = alumno;
        
        
        }
        //constructores
        public Evaluacion(Alumno alumno, List<Materia> materias) : this(alumno)// sobrecarga
        {          
            this.materias = materias;
        }

        public Evaluacion(Alumno alumno, List<Materia> materias, string carrera ) : this(alumno, materias)
        {
            this.carrera = carrera;
        }

        public Materia SetMateria 
        {
            set 
            {
                this.materias.Add(value);
                          
            }
                
        }

        public List<Materia>()


    }
}
