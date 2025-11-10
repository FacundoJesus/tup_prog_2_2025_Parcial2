using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    public class Camion
    {
        private double pesoControl = 0;
        public int Patente {  get; set; }
        public double PesoMax { get; set; }

        private Stack<Paquete> manifiesto = new Stack<Paquete>();

        public Camion(int patente, double peso)
        {
            this.Patente = patente;
            this.PesoMax = peso;
        }

        public bool AgregarPaquete(Paquete paquete) {

            if (paquete == null) throw new NullReferenceException("Paquete Nulo!");

            if (pesoControl < PesoMax)
            {
                manifiesto.Push(paquete);
                pesoControl += paquete.Peso;
                return true;
            }
            return false;
        }

        public Paquete QuitarPaquete()
        {
            Paquete paquete = null;
            if(manifiesto.Count > 0) {
                paquete = manifiesto.Pop();
                pesoControl -= paquete.Peso;
                return paquete;
            }
            return paquete;
        }

        public double CargaEnKg()
        {
            return pesoControl;
        }

        public string[] VerCarga()
        {
            string[] carga = new string[manifiesto.Count];
            int i = 0;
            foreach(Paquete p in manifiesto)
            {
                carga[i++] = p.ToString();
            }
            return carga;
        }

        public override string ToString()
        {
            return $"{this.Patente} - {this.PesoMax:f2}kg";
        }

    }
}
