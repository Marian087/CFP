using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Alumno
{
    public class EstadoAcademico
    {
        private Alumno alumno;
        private string carrera;
        private List <Materia> materia;



        //constructores

        private EstadoAcademico() 
        {
            this.materia = new List<Materia>();
            
        }
        public EstadoAcademico(Alumno alumno) : this()
        {
            this.alumno = alumno;
            
        }

        public EstadoAcademico (Alumno alumno,string carrera)
            :this(alumno)
        {
          
            this.carrera = carrera;
           
        }

        public EstadoAcademico(Alumno alumno,string carrera, List<Materia>materias) //sobrecarga
            :this(alumno,carrera)
        {
            this.materia = materias;
        
        
        }
       

        public Materia SetMateria 
        {
            set 
            {
                this.materias.Add(value);
                          
            }
                
        }
        public List<Materia> materias
        {
            get 
            {
                return this.materias;
            }
        
        }
        


    }
}
