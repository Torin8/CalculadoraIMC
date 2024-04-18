using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float Estatura { get; set; }
        public float Peso { get; set; }

        public void CalcularIMC()
        {
            var imc = Peso / (Estatura * Estatura);
            Console.WriteLine($"El imc de {nombre} es {imc}");
               }
    }
}
