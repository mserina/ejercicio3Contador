using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Contador.Servicios 
{
    internal class NumeroImplementacion : NumeroInterfaz
    {
        public int pedirNumero(int numero)
        {
            Console.WriteLine("Ingresa un numero");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}
