using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Jardin
    {
        public string nombre;

        public List<Planta> plantas = new List<Planta>();

        public Jardin(string nombre, int num_plantas)
        {
            this.nombre = nombre;
            for (int i = 0; i < num_plantas; i++)
            {
                Planta planta = new Planta("planta " + i);
                planta.minAguaExcedido += cuandoMinAguaExcedido;
                plantas.Add(planta);
            }

        }

        private void cuandoMinAguaExcedido(object sender, MinimoDeAguaExcedidoArgs args)
        {
            Planta planta = (Consola.Planta)sender;
            Console.WriteLine("¡¡Minimo de agua excedido!!\n" + planta.Nombre + " esta sedienta : " + args.porcentaje+ "%");
        }

        public bool siguienteDia()
        {
            bool todosMal = false;
            foreach (Planta planta in plantas)
            {
                if (planta.Ok())
                {
                    planta.decrementarAgua();
                }
                if(!planta.Ok())
                {
                    todosMal = !(todosMal && planta.Ok());
                }
                else
                {
                    todosMal = !(todosMal || planta.Ok());
                }
            }
            return todosMal;
        }

        public void tiempo()
        {
            bool todosMal = false;
            int i = 1;
            while (!todosMal)
            {
                Console.WriteLine("Dia " + i);
                mostrar();
                todosMal = siguienteDia();
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("Todas las plantas estan sedientas!!");

        }
        public void mostrar()
        {
            foreach (Planta planta in plantas)
            {
                Console.WriteLine(planta.ToString());
            }
        }

    }
}
