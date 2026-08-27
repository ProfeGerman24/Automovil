using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Automovil
    {
        // Atributos
        // marca, ruedaAuxilio, cantidadPuertas, tipoCombustible
        private string marca; // get 
        private bool tieneRuedaAuxilio;
        private int cantidadPuertas;
        private string tipoCombustible;
        private float kmRecorridos;
        private int velocidad;
        
        public Automovil(string marca, int cantidadPuertas, string tipoCombustible) // Constructor parametrizado
        {
            this.marca = marca;
            this.cantidadPuertas = cantidadPuertas;
            this.tipoCombustible = tipoCombustible;
        }

        // Métodos
        // Desplazarse(int velocidad, int kmAvanza), Frenar, TocarBocina

        public void MostrarAutomovil()
        {
            Console.WriteLine($"{marca} * {tieneRuedaAuxilio} * {cantidadPuertas} * {tipoCombustible} * {kmRecorridos}");
        }

        public void Desplazarse(int velocidad, int kmsAvanzados)
        {
            this.velocidad = velocidad;
            int i = 0;
            Console.WriteLine($"Velocidad: {this.velocidad}");
            while(i < kmsAvanzados)
            {
                this.kmRecorridos++;

                Console.WriteLine($"Kms recorridos: {this.kmRecorridos}");
                i++;
            }
        }

        public void Frenar()
        {
            //Console.WriteLine($"Velocidad: {this.velocidad}");

            while (this.velocidad >= 0)
            {
                Console.WriteLine($"Velocidad: {this.velocidad}");
                this.velocidad--;
            }

        }

        public void SetKmsRecorridos(float kmsRecorridos)
        {
            if (kmsRecorridos >= 0)
            {
                this.kmRecorridos = kmsRecorridos;
            }
        }

        public float GetKmsRecorridos()
        {
            return this.kmRecorridos;
        }








    }
}
