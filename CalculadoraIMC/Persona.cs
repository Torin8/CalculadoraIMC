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

        public void calcularimc()
        {
            var imc = Peso / (Estatura * Estatura);
            Console.WriteLine($"el imc de {Nombre} es {imc}");

        }
    }
}
