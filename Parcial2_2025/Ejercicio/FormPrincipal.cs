using Ejercicio.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Transactions;

namespace Ejercicio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(){InitializeComponent();}


        #region METODOS PRIVADOS DEL FORMULARIO
        private void MostrarListaZonas()
        {
            lsb1.Items.Clear();
            lsb2.Items.Clear();
            lsb3.Items.Clear();

            foreach (Paquete paquete in sistema.ListaPaquetes)
            {
                if (lsb3.Items.Count > 0 && paquete.ZonaDestino == "3")
                {
                    lsb3.Items.Add(paquete);
                }
                else
                if (lsb2.Items.Count > 0 && paquete.ZonaDestino == "2")
                {
                    lsb2.Items.Add(paquete);
                }
                else
                if (lsb1.Items.Count > 0 && paquete.ZonaDestino == "1")
                {
                    lsb2.Items.Add(paquete);
                }

            }

        }
        private void VerCarga()
        {
            lsbCarga.Items.Clear();
            if (camionElegido > -1)
            {
                foreach (string s in sistema.VerCargaCamion(camionElegido))
                {
                    lsbCarga.Items.Add(s);
                }
            }
        }
        #endregion

        int camionElegido = -1;
        Sistema sistema = new Sistema();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            camionElegido = cmbCamiones.SelectedIndex;

            VerCarga();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = null;

            if (lsb3.Items.Count > 0)
            {
                paquete = lsb3.Items[0] as Paquete;
            }
            else
            if (lsb2.Items.Count > 0)
            {
                paquete = lsb2.Items[0] as Paquete;
            }
            else
            if (lsb1.Items.Count > 0)
            {
                paquete = lsb1.Items[0] as Paquete;
            }


            if (paquete != null && camionElegido != -1)
            {
                double pesoActual = sistema.CargarPaquete(camionElegido, paquete);

                tbPesoAcumulado.Text = Convert.ToString(pesoActual);
                MostrarListaZonas();
                VerCarga();
            }
            else
            {
                MessageBox.Show("No hay Paquetes para descargar o no se ha seleccionado un Camion del Combobox");
            }

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (camionElegido != -1)
            {
                double pesoActual = sistema.RetirarPaquete(camionElegido);

                tbPesoAcumulado.Text = Convert.ToString(pesoActual);
                MostrarListaZonas();
                VerCarga();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Camion del Combobox");
            }
        }

        private void btnImportarPaquetesPedidos_Click(object sender, EventArgs e)
        {

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        #region SERIALIZACION Y DESERIALIZACION
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            /*FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011
                sistema = bf.Deserialize(fs) as Sistema;

            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error en la Deserialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if (fs != null) fs.Close();
            }
            */
            foreach (string s in sistema.CamionesCargados())
            {
                cmbCamiones.Items.Add(s);
            }

            MostrarListaZonas();
            VerCarga();
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Create, FileAccess.Write);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011
                bf.Serialize(fs, sistema);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la Serialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            */
        }
        #endregion


    }
}
