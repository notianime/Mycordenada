using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCords
{
    public class cordenada1
    {
        public Double latitud { get; set; }
        public Double longitude { get; set; }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            Console.WriteLine("Hola, ingresa coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<cordenada1> cordenadas = new List<cordenada1>();
            while (continuar)
            {
                String entrada = Console.ReadLine();
                if (entrada.ToLower().Equals("x"))
                {
                    continuar = false;
                    continue;
                }
                if (entrada.Split(',').Length != 2)
                {
                    continue;
                }
                // todo lo que es correcto
                Double latitudes;
                Double longitudes;
                cordenada1 micordenada = new cordenada1()
                {
                    latitud = Double.TryParse(entrada.Split(',')[0], out latitudes) ? latitudes:0,
                    longitude = Double.TryParse(entrada.Split(',')[1], out longitudes) ? longitudes : 0,
                };

                cordenadas.Add(micordenada);

            }

            Console.WriteLine("hasta luego... tu has ingresado: {0} coordenadas", cordenadas.Count);
            Console.ReadKey();
        }
    }
}
