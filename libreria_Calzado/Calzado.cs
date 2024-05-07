namespace libreria_Calzado
{
    public class Calzado
    {

            //atributos
            private string marca;
            private string modelo;
            private int talle;
            private int precio;

            //constructor
            public Calzado(string marca, string modelo, int talle, int precio)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.talle = talle;
                this.precio = precio;

            }
            /// metodos get y set
            public string Getmarca()
            {
                return marca;
            }


            public string GetModelo()
            {
                return modelo;

            }

            public int Gettalle()
            {
                return talle;
            }

            public int GetPrecio()
            {
                return precio;
            }

           
        List<Calzado> calzados = new List<Calzado>();







    }



 }

