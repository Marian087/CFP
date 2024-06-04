

using System.Drawing;

namespace PrimeraEvaluacion
{

    public class Testeo_Auto
    {
        // A. Atributos
        private string marca;
        private int cantCombustible;
        private Color color;
        private static List<Color> misColores;

        static Testeo_Auto() 
        {
           Testeo_Auto.misColores = new List<Color>();
        
        }




        // B. Constructor que inicializa todos los atributos
        public Testeo_Auto(string marca, int cantCombustible, string color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }

        // C. Métodos Get
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
            return color;
        }

        // D. Método AutoToString
        public string AutoToString()
        {
            return $"Marca: {marca}, Cantidad de Combustible: {cantCombustible}L, Color: {color}";
        }

        // E. Método Avanzar
        public bool Avanzar(int km)
        {
            int combustibleNecesario = km / 10;
            if (cantCombustible >= combustibleNecesario)
            {
                cantCombustible -= combustibleNecesario;
                return true;
            }
            return false;
        }
    }