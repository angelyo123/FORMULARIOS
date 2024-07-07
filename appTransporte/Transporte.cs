using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTransporte
{
    public class Transporte
    {
        protected String destinatario;
        protected String destino;
        protected double tm;
        protected double tarifa;

        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Destino { get => destino; set => destino = value; }  
        public double Tm { get => tm; set => tm = value; }
        public double Tarifa { get => tarifa; set => tarifa = value; }

        public Transporte() 
        {
            tm = 0;
            tarifa = 150;
        }

        public double Flete()
        {
            return tm * tarifa;
        }
    }
}
