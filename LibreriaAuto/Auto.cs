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


        string marca;
        int cantCombustible;
        Color color;

        public Auto(string marca, int cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }


        public string GetMarca()
        {
            return marca;
        }
        public int GetCantCombustible()
        {
            return cantCombustible;
        }
        public string GetColor()
        {
            return "";
        }

        public string AutoToString()
        {
            return $"El auto es de la marca {marca}, su color es {color} y la cantidad de combustible es {cantCombustible} litros.";
        }


        //El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer o no la cantidad de
        //kilometros recibo por parametro, tener en cuenta que para poder avanzar se debe tener conbustible y por
        //cada litro de combustible se pueden 10km.

        public bool Avanzar(int km)
        {
            if (cantCombustible >= 1 && cantCombustible >= km / 10)
            {
                cantCombustible -= km / 10;
                return true;

            }
            return false;
        }



        // CLASE DEL 15/05 ///////////////////////////////////


        public bool ConvertirStringEnColor(string nuevoColor)
        {
            bool resultado = true;

            switch (nuevoColor.ToLower())
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


        public static List<string> ColoresValidos()
        {
            List<string> list = new List<string>()
            {
                "Azul", "Rojo", "Verde", "Amarillo", "Negro", "Blanco"
            };
            return list;
        }




    }
}
