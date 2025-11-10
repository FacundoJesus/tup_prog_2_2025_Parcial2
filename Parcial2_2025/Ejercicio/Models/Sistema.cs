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
            listaCamiones.Add(new Camion(100, 2000));
            listaCamiones.Add(new Camion(101, 2500));
            listaCamiones.Add(new Camion(102, 1500));
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
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fs);
                //No tiene encabezado!
                while(!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();

                    string[] splitResult = linea.Split(';');

                    int nroRegistro = Convert.ToInt32(splitResult[0].Trim());
                    double peso = Convert.ToDouble(splitResult[1].Trim());
                    string zona = splitResult[2].Trim();

                    Paquete nuevoPaquete = new Paquete(nroRegistro, peso, zona);
                    ListaPaquetes.Add(nuevoPaquete);
                }
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                if(sr != null) sr.Close();
            }

        }

        public void RetirarCamion(FileStream fs, int posicion)
        {
            Camion camion = listaCamiones[posicion];
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fs);
                if (camion != null)
                {
                    foreach (string linea in VerCargaCamion(posicion))
                    {
                        sw.WriteLine(linea);
                    }
                }

            }
            catch(Exception ex) { throw ex; }
            finally
            {
                if (sw != null) sw.Close();
            }

        }
    }
}