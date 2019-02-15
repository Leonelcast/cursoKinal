using System;
using Llamada;
using System.Collections.Generic;


namespace Llamada
{
    class Program
    {
        static void Main(string[] args)
        {
            Llamadas llamadaDepto = new LlamadaProvincial();
            llamadaDepto.NumDestino = "123";
            llamadaDepto.NumOrigen = "456";
            ((LlamadaProvincial)llamadaDepto).Franja = 0;
            ((LlamadaProvincial)llamadaDepto).Precio1=1.5;
            ((LlamadaProvincial)llamadaDepto).Duracion=10;
            Llamadas llamadaLocal = new LlamadaLocal();
            llamadaLocal.NumDestino="789";
            llamadaLocal.NumOrigen="1234";
            llamadaLocal.Duracion = 5;
            ((LlamadaLocal)llamadaLocal).Precio = 0.96;
            Llamadas otraLocal = new LlamadaLocal();
            otraLocal.NumDestino="111";
            otraLocal.NumOrigen="222";
            otraLocal.Duracion = 25;
            ((LlamadaLocal)otraLocal).Precio = 0.96;

            List<Llamadas>llamadasRealizadas = new List<Llamadas>();
            llamadasRealizadas.Add(llamadaDepto);
            llamadasRealizadas.Add(llamadaLocal);
            llamadasRealizadas.Add(otraLocal);
            foreach(Llamadas item in llamadasRealizadas)
            {
                if(item is LlamadaLocal)
                {
                    Console.WriteLine($"Precio Llamada local ({item}): {item.CalcularPrecio()}");
                }
                else if (item is LlamadaProvincial)
                {
                    Console.WriteLine($"Precio Llamada provincial ({item}): {item.CalcularPrecio()}");
                }
            }
            Console.ReadKey();
        }
    }
}
