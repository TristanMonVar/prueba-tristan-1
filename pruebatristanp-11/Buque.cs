using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebatristanp_11
{
    internal class Buque
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List<Container> listaContainers = new List<Container>();

        public string Codigo { get { return codigo; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public int CantidadContainers { get { return cantidadContainers; } set { cantidadContainers = value; } }
        public int CantidadContainersCargados { get { return cantidadContainersCargados; } set { cantidadContainersCargados = value; } }
        public int GastoTransporte { get { return gastoTransporte; } set { gastoTransporte = value; } }
        public List<Container> Containers { get { return listaContainers; } set { listaContainers = value; } }

        public Buque(string codigo)
        {
            if (codigo.Length >= 5)
            {
                this.codigo = codigo;
            }
            else
            {
                Console.WriteLine("El código es demasiado corto");
            }
        }


        public Buque(string codigo, string nombre, string pais, int cantidadContainers) : this(codigo)
        {
            if (codigo.Length >= 5)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.pais = pais;
                this.cantidadContainers = cantidadContainers;
            }
            else
            {
                Console.WriteLine("Error código es demasiado corto");
            }

        }



        public bool subirContainer(Container container)
        {
            bool esPosible = false;

            int tamañoContainer = 0;

            if (container.Tamaño == 20)
            {
                tamañoContainer = 1;
            }
            else if (container.Tamaño == 40)
            {
                tamañoContainer = 2;
            }

            int espacioFinal = cantidadContainersCargados + tamañoContainer;

            if (espacioFinal > cantidadContainers)
            {
                Console.WriteLine("Error no hay espacio");
            }
            else
            {
                esPosible = true;
                cantidadContainersCargados = espacioFinal;
                container.Buque = new Buque(codigo, nombre, pais, cantidadContainers);
                listaContainers.Add(container);
                Console.WriteLine("El container ha sido agregado al buque");
            }



            return esPosible;

        }


        public void ListarContainers()
        {
            foreach (Container container in listaContainers)
            {
                string str = container.ToString("A");
                Console.WriteLine(str);
            }

        }



    }
}
