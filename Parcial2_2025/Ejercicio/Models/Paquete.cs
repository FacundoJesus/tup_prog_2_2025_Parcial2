using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    public class Paquete
    {
        public int NroRegistro { get; set; }
        public double Peso { get; set; }
        public string ZonaDestino { get; set; }

        public Paquete(int id, double peso, string zonaDestino)
        {
            this.NroRegistro = id;
            this.Peso = peso;
            this.ZonaDestino = zonaDestino;
        }

        public override string ToString()
        {
            return $"{this.NroRegistro};{this.Peso:f2};{this.ZonaDestino}";
        }
    }
}
