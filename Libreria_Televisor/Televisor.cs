namespace Libreria_Televisor
{
    public class Televisor
    {
        //atributos

        private string marca;
        private int pulgada;
        private string modelo;
        private string color;
       
        

        ///constructores
        public Televisor(string marca, int pulgada, string modelo, string color)
        {
            this.marca = marca;
            this.pulgada = pulgada;
            this.modelo = modelo;
            this.color = color;
           
        }

        public string GetMarca()
        {
            return marca;

        }
        public int GetPulgada()
        {
            return pulgada;

        }
        public string GetModelo()
        {
            return modelo;

        }
        public void SetColor(string color)
        {
            color = color;

        }


    }



}
