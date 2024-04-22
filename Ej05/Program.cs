namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5. (E/S) En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología.
            //El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
            //Área Porcentaje del presupuesto
            //Cardiología 40 %
            //Pediatría 45 %
            //Traumatología 15 %


            double presupuestoAnual;
            double porcentajeCardiologia;
            double porcentajePediatria;
            double porcentajeTraumatologia;

            porcentajeCardiologia = 0.40;
            porcentajePediatria = 0.45;
            porcentajeTraumatologia = 0.15;

            Console.WriteLine("Por favor ingrese el monto del presupuesto anual. ");
            presupuestoAnual = Convert.ToDouble(Console.ReadLine());

            double presupuestoCardiologia = presupuestoAnual * porcentajeCardiologia;
            double presupuestoPediatria = presupuestoAnual * porcentajePediatria;
            double presupuestoTraumatologia = presupuestoAnual * porcentajeTraumatologia;

            Console.WriteLine($"El presupuesto anual es de $ {presupuestoAnual} .");

            Console.WriteLine($"El presupuesto anual destinado al área de Cardiología es de $ {presupuestoCardiologia} .");

            Console.WriteLine($"El presupuesto anual destinado al área de Pediatria es de $ {presupuestoPediatria} .");

            Console.WriteLine($"El presupuesto anual destinado al área de Traumatológia es de $ {presupuestoTraumatologia} .");
        }

    }
}
}
