using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Planta
    {
        public event EventHandler<MinimoDeAguaExcedidoArgs> minAguaExcedido;
        public static Random rand { private get; set; }
        public static double MinAgua { get; set; }
        public string Nombre { get; private set; }
        private double agua_;
        private double agua
        {
            get { return agua_; }
            set
            {
                if (value < MinAgua)
                {
                    if (minAguaExcedido != null)
                    {
                        minAguaExcedido(this, new MinimoDeAguaExcedidoArgs(value));
                        agua_ = value;
                    }
                }
                else {
                    agua_ = value;
                }
            }
        }

        public Planta(string nombre)
        {
            this.Nombre = nombre;
            this.agua = 100.0;
        }

        public void decrementarAgua()
        {
            agua -= rand.Next(10, 30);
        }

        public bool Ok()
        {
            if (agua >= MinAgua)
                return true;
            return false;
        }

        public override string ToString()
        {
            return Nombre + " agua: " + agua + "%";
        }
    }

    public class MinimoDeAguaExcedidoArgs : EventArgs
    {

        public double porcentaje { get; set; }

        public MinimoDeAguaExcedidoArgs(double porcentaje)
        {
            this.porcentaje = porcentaje;
        }
    }
}
