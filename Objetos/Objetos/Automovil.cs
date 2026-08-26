using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Automovil
    {
        // Atributos
        // marca, ruedaAuxilio, cantidadPuertas, tipoCombustible
        public string marca;
        public bool tieneRuedaAuxilio;
        public int cantidadPuertas;
        public string tipoCombustible;
        public float kmRecorridos;
        
        // Metodos
        // Desplazarse, Frenar, TocarBocina

        public void MostrarAutomovil()
        {
            Console.WriteLine($"{marca} - {tieneRuedaAuxilio} - {cantidadPuertas} - {tipoCombustible} - {kmRecorridos}");
        }


    }
}
