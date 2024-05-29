using Libreria_Colectivo;
using System.Security.Cryptography.X509Certificates;


namespace Testeo_Colectivo
{
    internal class Testeo_Colectivo
    {
        static void Main(string[] args)
        {
         
            Colectivo colectivo1 = new Colectivo("ADM 123",85, "MONSA",50,"Lanus","Retiro");
            Colectivo colectivo2 = new Colectivo("SIY 846", 85, "CAT", 30, "Lomas", "Retiro");
            Colectivo colectivo3 = new Colectivo("MAR 783", 85, "NORTE", 55, "Constitucion", "Recoleta");
            Colectivo colectivo4 = new Colectivo("PIU 543", 85, "SUR", 45, "Once", "Barracas");
            Colectivo colectivo5 = new Colectivo("CDD 252", 85, "MONSA", 20, "Lanus", "Retiro");
            Colectivo colectivo6 = new Colectivo("WAR 653", 85, "NORTE", 65, "Caballito", "Flores");


            Colectivo[] misColectivos = new Colectivo[5];

            
            List<Colectivo>listaDeColectivos = new List<Colectivo>(); //ACA SE CREA UNA NUEVA INSTANCIA DE LA LISTA.//

            //La diferencia entre un arrays y la lista. Es que la lista no tiene limite para su utilizaciòn.

            //como agregar elementos a la colecciòn.

            listaDeColectivos.Add(colectivo1);
            listaDeColectivos.Add(colectivo2);
            listaDeColectivos.Add(colectivo3);
            listaDeColectivos.Add(colectivo4);
            listaDeColectivos.Add(colectivo5);


            Console.WriteLine("Mostrar La lista completa");
                      
            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            
            Console.WriteLine("Mostrando La lista sin la linea 22");
           int  indice = retornarIndiceEnLista(listaDeColectivos, 22);
            
            listaDeColectivos.RemoveAt(indice);
            foreach(Colectivo item in listaDeColectivos) 
            {
                Console.WriteLine(item.ColectivoToString());

            }






            listaDeColectivos.Sort((Colectivo.CompararColectivosPorLinea));

            Console.WriteLine("***ordenado por empresa * **");

            
            
        }

        //para eliminar un item en particular , eliminar el elemento 22 de mi lista.
        public static int retornarIndiceEnLista( List<Colectivo>lista, int linea) 
        {
            int indice = -1;
            foreach(Colectivo item in lista) 
            {
                if (item.Getlinea() == linea) 
                {
                    indice = lista.IndexOf(item);                
                
                }
            
            
            }


            return indice;
        
        }
       


       




    }
}
