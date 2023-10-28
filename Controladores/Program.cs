using Ejercicio3Contador.Servicios;

namespace Ejercicio3Contador
{
    /// <summary>
    /// Clase principal 
    /// msm - 281023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodos main, contiene todo el procedimiento de la aplicacion
        /// msm - 281023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            //Variables
            int numero = 0;
            

            //Objetos
            NumeroInterfaz num = new NumeroImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();


            //Metodos
            int numeroGuardado = num.pedirNumero(numero);
            op.operacion(numeroGuardado);

        }
    }
}
