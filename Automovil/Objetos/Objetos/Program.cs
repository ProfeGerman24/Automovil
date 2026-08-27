namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil unAuto = new Automovil("Ford Ka", 4, "Diesel");
            unAuto.SetKmsRecorridos(20000);

            Console.WriteLine($"El auto recorrió: {unAuto.GetKmsRecorridos()}");
            
            
            //unAuto.MostrarAutomovil();








            //Automovil otroAuto = new Automovil("Chevrolet lalal", 2, "GNC");

            //Console.WriteLine("###################");

            //otroAuto.MostrarAutomovil();
            //Console.WriteLine("###################");

            //unAuto.Desplazarse(50, 10);
            //Console.WriteLine("###################");
            //unAuto.Frenar();
        
        }

    }
}
