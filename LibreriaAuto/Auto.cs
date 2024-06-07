using System.Drawing;

namespace LibreriaAuto
{
    public class Auto
    {
        //5. Crear la clase de instancia Auto.

        //La misma debe tener:
        //A.Los atributos marca, cantCombustible, color.
        //B.un constructor que inicialice todos los atributos.
        //C.Solo metodos Get() para todos sus atributos.
        //D.El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
        //E.El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer o no la cantidad de kilometros recibo por parametro, tener en cuenta que para poder avanzar se debe tener conbustible y por cada litro de combustible se pueden 10km.
        //F.En un proyecto de consola crear un objeto del tipo Auto, mostrar todos su valores y dentro de un bucle repetitivo usar el metodo avanzar(), este debera repetirse hasta que el auto agote su combustible y se debera informar cuantas repeticiones logra realizar.


        private string marca;
        private double cantCombustible; 
        private Color color;
        private static List<Color> misColores;
        static Random peso;


        static Auto() 
        { 
            Auto.misColores = new List<Color>();
            Auto.peso = new Random();        
        
        }
        //metodos get
        public Auto(string marca, double CantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color =color;
        }
        public string GetMarca()
        {
            return marca;
        }
        public int GetCantCombustible()
        {
            return (int) cantCombustible;
        }
        public string GetColor()
        {
            return "";
        }

        //public bool SetColor(Color nuevoColor) // este paso permite al usuario modificar el color.
        //{
        //    bool retorno = false;

        //    if (nuevoColor == Color.Green || nuevoColor == Color.Blue && nuevoColor != Color.Red)
        //    {

        //        retorno = false;

        //    }
        //    else
        //    {
        //        this.color = nuevoColor;
        //        retorno = true;

        //    }
        //    return retorno;
        //}


        // metodo para agregar una lista de opciones de colores al combobox.
        public static List<string> ColoresValidos()
        {
            List<string> list = new List<string>()
            {
                "Azul", "Rojo", "Verde", "Amarillo", "Negro", "Blanco"
            };
            return list;

        }
        public override string ToString() // Metodo para sobre escribir.// es para que muestre los datos de "Auto"
        {
            return $"El auto es de la marca {marca}, la cantidad de combustible es {cantCombustible} litros y su color es {color}.";//Sirve para que aparezcan los datos /datos cargados separados para leer.
        }




        //public string AutoToString()
        //{
        //    return $"El auto es de la marca {marca}, la cantidad de combustible es {cantCombustible} litros y su color es {color}.";
        //}
                                            

        //El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer o no la cantidad de
        //kilometros recibo por parametro, tener en cuenta que para poder avanzar se debe tener conbustible y por
        //cada litro de combustible se pueden 10km.

        public bool Avanzar(int km)
            {
            bool retorno = false;
            double combustibleNecesario = (double) km / 10;

            if (cantCombustible >= 1 && cantCombustible >= combustibleNecesario)
            {
                cantCombustible -= combustibleNecesario;
                return true;

            }
            return retorno;
        }
        //Metodo para convertir dato string a double.
        public  bool ConvertirStringEnCombustible( string CantCombustible) 
        {
            bool retorno = false;

            if (double.TryParse(CantCombustible, out double CombustibleValido)) 
            {
                this.cantCombustible = CombustibleValido;
                retorno = true;

            }
            return retorno;     
               
        }
        public static bool ConvertirStringaInt(string ValorAconvertir) 
        {
           return double.TryParse(cantCombustible, out double CombustibleValido);

        }

        public bool ConvertirStringEnColor(string nuevoColor)
        {
            bool resultado = true;

            switch (nuevoColor.ToLower())// el tolower poner todo en minuscula, estandariza.
            {
                case "rojo":
                    this.color = Color.Red;
                    break;
                case "verde":
                    this.color = Color.Green;
                    break;
                case "azul":
                    this.color = Color.Blue;
                    break;
                default:
                    resultado = false;
                    break;

            }
            return resultado;
        }


    }
}
