// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebatristanp_11

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido ");
            var buque1 = new Buque("35899", "San Amelia", "Chile", 8);
            var buque2 = new Buque("35877", "Lucy", "Chile", 8);
            var buque3 = new Buque("35866", "Jenny", "Colombia", 10);

            var container1 = new Container("11111","EVO1",4000,20,true, 2500);
            var container2 = new Container("11222", "EVA1", 2000, 20, true, 1500);
            var container3 = new Container("11420", "EVO2", 3000, 40, false, 2500);
            var container4 = new Container("69169", "EVA4", 5000, 40, true, 5000);
            /*
            container1.ToString("A");
            container2.ToString("A");
            container3.ToString("A");
            container4.ToString("A");
            */          
            buque1.subirContainer(container1);
            buque1.subirContainer(container2);
            buque2.subirContainer(container3);
            buque2.subirContainer(container4);
            buque1.ListarContainers();
            container4.PuedeSubir(container4.CantidadMaxima, 2000);
            container1.SacarPeso(200);
            container3.ValorPagoInspeccion();

            Console.WriteLine("El costo container 1 es " + container1.CalcularGastosEnvio() + " pesos ");
            Console.WriteLine("El costo container 2 es " + container2.CalcularGastosEnvio() + " pesos ");
            Console.WriteLine("El costo container 3 es " + container3.CalcularGastosEnvio() + " pesos ");
            Console.WriteLine("El costo container 4 es " + container4.CalcularGastosEnvio() + " pesos ");






            Console.ReadKey();

        }
    }
}

