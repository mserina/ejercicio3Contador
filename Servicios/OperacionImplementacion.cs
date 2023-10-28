using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Contador.Servicios
{
    /// <summary>
    /// Clase que contiene toda la logica de los metodos
    /// msm - 281023
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void operacion(int numero)
        {            
            //Controla el numero de filas 
            for (int i = 0; i <= numero; i++)
            {
            //Este for se encarga de controlar la impresion en base al for anterior
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }      
        }
    }
}
