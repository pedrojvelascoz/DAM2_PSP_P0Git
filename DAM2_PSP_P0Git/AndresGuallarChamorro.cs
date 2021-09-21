using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_PSP_P0Git
{
    class AndresGuallarChamorro
    {
        public const string NOMBRE = "Andrés";
        public string curso { get; set; }
        public int edad { get; set; }
        public AndresGuallarChamorro()
        {
            curso = "Desarrollo de Aplicaciones Multiplataforma";
            edad = 20;
            Console.WriteLine("Hola soy " + NOMBRE + ", tengo " + edad + " y estudio " + curso);
        }
    }
}
