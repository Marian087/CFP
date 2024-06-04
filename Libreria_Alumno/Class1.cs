namespace Libreria_Alumno;

public class Alumno;
{
    // Atributos estáticos y de instancia
    private static Random random;
    private string nombre;
    private string apellido;
    private int legajo;
    private int notaPrimerParcial;
    private int notaSegundoParcial;
    private int notaFinal;

    // Constructor estático
    static Alumno()
    {
        random = new Random();
    }

    // Constructor de instancia
    public Alumno(string nombre, string apellido, int legajo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.legajo = legajo;
        this.notaFinal = -1; // Inicializar con -1
    }

    // Setter para nota del primer parcial
    public void SetNotaPrimerParcial(int nota)
    {
        this.notaPrimerParcial = nota;
    }

    // Setter para nota del segundo parcial
    public void SetNotaSegundoParcial(int nota)
    {
        this.notaSegundoParcial = nota;
    }

    // Método privado para calcular el promedio
    private double CalcularPromedio()
    {
        return (notaPrimerParcial + notaSegundoParcial) / 2.0;
    }

    // Método para calcular la nota final
    public int CalcularNotaFinal()
    {
        if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
        {
            notaFinal = random.Next(6, 11); // Genera un número aleatorio entre 6 y 10 (incluidos)
        }
        else
        {
            notaFinal = -1;
        }

        return notaFinal;
    }

    // Método para mostrar la información del alumno
    public string Mostrar()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nombre: {nombre}");
        sb.AppendLine($"Apellido: {apellido}");
        sb.AppendLine($"Legajo: {legajo}");
        sb.AppendLine($"Nota Primer Parcial: {notaPrimerParcial}");
        sb.AppendLine($"Nota Segundo Parcial: {notaSegundoParcial}");
        sb.AppendLine($"Promedio: {CalcularPromedio()}");
        sb.AppendLine($"Nota Final: {notaFinal}");

        return sb.ToString();
    }


}
