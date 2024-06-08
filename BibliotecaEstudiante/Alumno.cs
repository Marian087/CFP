using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Libreria_Alumno
{
    public class Alumno

    {
        // Tendrá un constructor estático que inicializará el atributo estático random.
        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido
        //y legajo.
        //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo
        //notaPrimerParcial.
        //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo
        //notaSegundoParcial.
        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        //El método CalcularNotaFinal deberá retornar la nota del final con un número
        //aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo
        //parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor - 1.
        //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos
        //los datos de los alumnos:





        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido
        //y legajo.
        private static Random random;  //es un atributo de instancia. Tendrá un constructor estático que inicializará el atributo estático random.

        private string nombre;
        private string apellido;
        private int legajo;
        
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        static Alumno() 
        {
            random = new Random();
        
        }      
        

        public int Legajo
        {
            set
            {
                this.legajo = value;
            }
            get
            {
                return this.legajo;

            }
        }

        // constructor de instancia inicializar los atributos
        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }
        public int GetLegajo()
        {
            return this.legajo;
        }

        ///El método CalcularNotaFinal deberá retornar la nota del final con un número
        //aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo
        //parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor - 1.
        public double CalcularNotaFinal()
        {
            double resultado = -1;

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                double notaFinal = random.Next(6, 10);
                resultado = notaFinal;

            }
            return resultado;

        }

        ///El método privado CalcularPromedio retornará el promedio de las dos notas.
        private double CalcularPromedio()// casteo a double
        {
            double promedio = ((double)notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;

        }
        //public string Mostrar()
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {this.apellido},{this.nombre}- Leg: nº{this.Legajo}");
            sb.AppendLine($"Nota Primer Parcial: {notaPrimerParcial} - 2º Parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            double notaFinal = this.CalcularNotaFinal();

            if(notaFinal != 0) 
            {
                sb.AppendLine($"Nota Final: {notaFinal}");          
                      
            }
            else 
            {
                sb.AppendLine($"Alumno Desaprobado");
            }
            return sb.ToString();
        }

        public static List<Alumno> ListAlumnos() 
        {
            return new List<Alumno>
            {
                new Alumno ("Gomez","Ezequiel", 521)

            };

              
        
        }


        //metodos set para cambiar el valor del atributo
        //public void SetNotaPrimerParcial (int nota) 
        //{
        //    this.notaPrimerParcial = nota;

        //}



        public int NotaPrimerParcial
        {
            get => notaPrimerParcial;

            set
            {
                if (value >= 0 && value <= 10)
                {
                    notaPrimerParcial = value;
                }
                else
                {
                    notaPrimerParcial = 0;
                }
            }
        }


        public void SetNotaSegundoParcial(int nota)
        {
            this.notaPrimerParcial = nota;

        }

        public int NotaSegundoParcial
        {
            get => notaSegundoParcial;

            set
            {
                if (value >= 0 && value <= 10)
                {
                    notaSegundoParcial = value;
                }
                else
                {
                    notaSegundoParcial = 0;
                }
            }
        }

        //if (!int.TryParse(txt_Legajo.Text, out int legajo))
        //{       
        //}





    }
}
