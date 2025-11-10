using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    public class Sistema
    {
        public List<Paquete> ListaPaquetes = new List<Paquete>();
        private List<Camion> listaCamiones = new List<Camion>();

        public Sistema()
        {
            listaCamiones.Add(new Camion(100, 50.5));
            listaCamiones.Add(new Camion(101, 20));
            listaCamiones.Add(new Camion(102, 30.70));
        }

        public string[] CamionesCargados()
        {
            string[] camionesCargados = new string[listaCamiones.Count];
            int i = 0;
            foreach (Camion c in listaCamiones) {
                camionesCargados[i++] = c.ToString();
            }
            return camionesCargados;
        }



        public double CargarPaquete(int posicion, Paquete paquete) 
        {
            Camion camion = listaCamiones[posicion];

            if(camion != null)
            {
                camion.AgregarPaquete(paquete);
                ListaPaquetes.Remove(paquete);
                
            }

            return camion.CargaEnKg();

        }

        public double RetirarPaquete(int posicion)
        {
            Camion camion = listaCamiones[posicion];

            if (camion != null)
            {
                Paquete paquete = camion.QuitarPaquete();
                ListaPaquetes.Add(paquete);

            }

            return camion.CargaEnKg();

        }

        public string[] VerCargaCamion(int posicion)
        {
            Camion camion = listaCamiones[posicion];

            return camion.VerCarga();

        }
        

        public void Descargar(FileStream fs)
        {

        }

        public void RetirarCamion(FileStream fs, int poisicion)
        {

        }
    }
}