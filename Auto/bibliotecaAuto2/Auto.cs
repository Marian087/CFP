using System.Drawing;

namespace bibliotecaAuto2
{
    public class Auto
    {

        // A. Atributos
        private string marca;
        private double cantCombustible;
        private string color;

        // B. Constructor que inicializa todos los atributos
        public Auto(string marca, int cantCombustible, string color)
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

        public double GetCantCombustible()
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
            bool retorno = false;

            double combustibleNecesario = (double) km / 10;
            if (cantCombustible >= combustibleNecesario)
            {
                cantCombustible -= combustibleNecesario;
                return true;
            }
            return retorno;
        }




    }






}
