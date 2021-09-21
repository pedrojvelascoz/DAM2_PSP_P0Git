using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_PSP_P0Git
{
    class AsierSanchezBarberena
    {
        //Un comentario de relleno
        public const string NOMBRE = "Asier";
        public int edad { get; set; }
        public AsierSanchezBarberena()
        {
            edad = 19;
            Console.WriteLine("He nacido, ¡con {0} años ya!", edad);
        }
    }
}
