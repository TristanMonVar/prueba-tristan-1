using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebatristanp_11
{
    internal class Container
    {
        private string codigo;
        private string marca;
        private int capacidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        public Buque buque;

        /// <summary>
        /// Getters y setters de la clase
        /// </summary>
        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value; }
        public int CantidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool EsRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int PesoActual { get => pesoActual; set => pesoActual = value; }
        public Buque Buque { get => buque; set => buque = value; }

   
        public Container(string codigo) => this.codigo = codigo;

        
        public Container(string codigo, string marca, int cantidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual)
        {

            if (0 < pesoActual)
            {
                if (PuedeSubir(cantidadMaxima, pesoActual))
                {
                    if (tamaño == 20 || tamaño == 40)
                    {
                        this.codigo = codigo;
                        this.marca = marca;
                        this.capacidadMaxima = cantidadMaxima;
                        this.esRefrigerado = esRefrigerado;
                        this.pesoActual = pesoActual;
                        this.tamaño = tamaño;
                    }
                    else
                    {
                        Console.WriteLine("Error, containers solo pueden medir 20 o 40 pies");
                    }
                }
                else
                {
                    Console.WriteLine("Error peso actual invalido.");
                }
            }
            else
            {
                Console.WriteLine("El peso actual es igual o menor a 0");
            }

        }


       
        public void SacarPeso(int pesoSacado)
        {
            int pesoResult = pesoActual - pesoSacado;

            if (pesoResult >= 0)
            {
                pesoActual = pesoResult;
            }
            else
            {
                Console.WriteLine("Error peso actual no valido. " + pesoActual);
            }
        }

       
        public int ValorPagoInspeccion()
        {
            int costoInspeccion = pesoActual * 5;

            return costoInspeccion;
        }

        public int CalcularGastosEnvio()
        {
            int coste = 0;
            if (tamaño == 20)
            {
                coste = 3500;
            }
            else if (tamaño == 40)
            {
                coste = 9000;
            }
            return coste;
        }

        public bool PuedeSubir(int pesoMaximo, int pesoPorSubir)
        {
            bool esPosible = false;
            int pesoResultante = pesoPorSubir + pesoActual;

            if (pesoMaximo >= pesoResultante)
            {
                esPosible = true;
                Console.WriteLine("Es posible subir");
            }
            else
            {
                Console.WriteLine("Error, peso invalido. ");
            }

            return esPosible;
        }

        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "A";

            switch (fmt.ToUpperInvariant())
            {
                case "A":
                    return string.Format("el container posee el Codigo {0}, de Marca {1}, su Capacidad máxima es de {2} kilogramos y es {3} pies de largo  " +
                        "estado refrigerado es: {4}, su Peso actual es de {5} kilogramos ( codigo del Buque: {6}).",
                        codigo, marca, capacidadMaxima, tamaño, esRefrigerado, pesoActual, buque.Codigo);
                default:
                    string msg = string.Format("'{0}' is an invalid format string",
                                               fmt);
                    throw new ArgumentException(msg);
            }
        }

    }

}
