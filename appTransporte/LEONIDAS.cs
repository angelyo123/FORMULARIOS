using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTransporte
{
    public class LEONIDAS: Transporte
    {
        public double Tarifario()
        {
            switch (destino)
            {
                case "Arequipa": case "Ilo": case "Tacna": tarifa = 200; break;
                case "Cajamarca": case "Piura": case "Tumbes": tarifa = 220; break;
                default: tarifa = 150; break;
            }
            return tarifa;
        }
        public double Seguro()
        {
            return 0.05 * Flete();
        }
        public double Monto()
        {
            return Tarifario() + Seguro();
        }
    }
}
