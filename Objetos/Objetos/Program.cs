namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil unAuto = new Automovil();

            unAuto.tipoCombustible = "Diesel";
            unAuto.cantidadPuertas = 4;
            unAuto.tieneRuedaAuxilio = false;
            unAuto.kmRecorridos = 50000;
            unAuto.marca = "Ford Ka";


            Automovil otroAuto = new Automovil();
            otroAuto.tipoCombustible = "GNC";
            otroAuto.cantidadPuertas = 2;
            otroAuto.tieneRuedaAuxilio = true;
            otroAuto.kmRecorridos = 20000;
            otroAuto.marca = " Chevrolet lalal";

            unAuto.MostrarAutomovil();
            otroAuto.MostrarAutomovil();

        }

    }
}
