using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteGrup
{
    public partial class JuegoAdmin : Form
    {

        BindingList<Pregunta> generoMusical1 = new BindingList<Pregunta>();
        BindingList<Pregunta> listaMostrar = new BindingList<Pregunta>();

        String idioma;
        String genere;
        public JuegoAdmin()
        {
            InitializeComponent();
            ObtencionJsons("Rock", "");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres modificarlo?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                Pregunta preguntaModificar = (Pregunta)dataGridView1.CurrentRow.DataBoundItem;
                List<Respuesta> respuestasModificar = new List<Respuesta>();
                listaMostrar.Remove(preguntaModificar);
                dataGridView1.DataSource = listaMostrar;
                String textopregunta = preguntaModificar.PreguntaTexto;
                textBoxPregunta.Text = textopregunta;


                idioma = SeleccionarIdioma(idioma);

                if (preguntaModificar.Dificult.Equals(radioButtonFacil.Text))
                {
                    radioButtonFacil.Checked = true;
              
                }
               else if (preguntaModificar.Dificult.Equals(radioButtonMedio.Text))
                {
               
                    radioButtonMedio.Checked = true;
                  
                }
                else if (preguntaModificar.Dificult.Equals(radioButtonDificil.Text))
                {
                 
                    radioButtonDificil.Checked = true;
                }

                foreach (Respuesta item in preguntaModificar.Respuestas)
                {
                    respuestasModificar.Add(item);
                }

                textBoxResposta1.Text = respuestasModificar[0].Texto;
                if (respuestasModificar[0].IsTrue == true)
                {
                    radioButtonCiertoPrimero.Checked = true;
                }
                else
                {
                    radioButtonFalsoPrimero.Checked = true;
                }
                textBoxResposta2.Text = respuestasModificar[1].Texto;
                if (respuestasModificar[1].IsTrue == true)
                {
                    radioButtonCiertoSegundo.Checked = true;
                }
                else
                {
                    radioButtonFalsoSegundo.Checked = true;
                }
                textBoxResposta3.Text = respuestasModificar[2].Texto;
                if (respuestasModificar[2].IsTrue == true)
                {
                    radioButtonCiertoTercero.Checked = true;
                }
                else
                {
                    radioButtonFalsoTercero.Checked = true;
                }
                textBoxResposta4.Text = respuestasModificar[3].Texto;
                if (respuestasModificar[3].IsTrue == true)
                {
                    radioButtonCiertoCuarto.Checked = true;
                }
                else
                {
                    radioButtonFalsoCuarto.Checked = true;
                }

                GuardarEnJsonGeneros(preguntaModificar.Gender, idioma); //pasar el idioma para concatenar en la cadena, si es castellano se pasa "" asi evitamos volver a picar
            }
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAdmin ma = new MenuAdmin();

            ma.ShowDialog();
        }

        private void personajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Personatges p = new Personatges();
            //p.ShowDialog();

        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            String pregunta = textBoxPregunta.Text;
            String gender = "";
            String dificult = "";
            String respuesta1 = textBoxResposta1.Text;
            String respuesta2 = textBoxResposta2.Text;
            String respuesta3 = textBoxResposta3.Text;
            String respuesta4 = textBoxResposta4.Text;
            bool isTrueRes1 = false;
            bool isTrueRes2 = false;
            bool isTrueRes3 = false;
            bool isTrueRes4 = false;
            bool control;
            List<Respuesta> Respuestas = new List<Respuesta>();
            Respuesta primera, segunda, tercera, cuarta;
            Pregunta preguntaConRespuestas;

            dificult = SeleccionarDificultadPregunta(dificult);

            gender = SeleccionarGenero(gender);

            isTrueRes1 = ControlPrimeraRespuesta(isTrueRes1);
            isTrueRes2 = ControlSegundaRespuesta(isTrueRes2);
            isTrueRes3 = ControlTerceraRespuesta(isTrueRes3);
            isTrueRes4 = ControlCuartaPregunta(isTrueRes4);
            if (isTrueRes1 == false && isTrueRes2 == false && isTrueRes3 == false && isTrueRes4 == false)
            {
                MessageBox.Show("Todas las respuestas son falsas,debe haber una sola correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isTrueRes1 == true && isTrueRes2 == true && isTrueRes3 == true && isTrueRes4 == true)
            {
                MessageBox.Show("Todas las respuestas son ciertas, debe haber una sola correcta y las demás falsas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                control = controlPreguntasVacias(pregunta, respuesta1, respuesta2, respuesta3, respuesta4, gender, dificult);
                if (control)
                {
                    primera = ObtenerObjetoRespuesta(respuesta1, isTrueRes1);
                    segunda = ObtenerObjetoRespuesta(respuesta2, isTrueRes2);
                    tercera = ObtenerObjetoRespuesta(respuesta3, isTrueRes3);
                    cuarta = ObtenerObjetoRespuesta(respuesta4, isTrueRes4);
                    Respuestas = AnadirLista(primera, segunda, tercera, cuarta);
                    preguntaConRespuestas = new Pregunta(pregunta, Respuestas, dificult, gender);

                    generoMusical1.Add(preguntaConRespuestas);
                    listaMostrar.Add(preguntaConRespuestas);

                    idioma = SeleccionarIdioma(idioma);
                    GuardarEnJsonGeneros(preguntaConRespuestas.Gender, idioma);



                    dataGridView1.DataSource = listaMostrar;
                    //dataGridView1.DataSource = generoMusical1;

                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Falta un campo a rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool controlPreguntasVacias(String pregunta, String respuesta1, String respuesta2, String respuesta3, String respuesta4,
            String gender, String dificult)
        {
            bool control = true;
            if (pregunta.Equals("") || respuesta1.Equals("") || respuesta2.Equals("") || respuesta3.Equals("") || respuesta4.Equals("")
                || gender.Equals("") || dificult.Equals(""))
            {
                control = false;
            }
            return control;
        }

        private void ObtencionJsons(String a, String idioma)
        {
            OpenFileDialog openFiDi = new OpenFileDialog();
            openFiDi.InitialDirectory = Application.StartupPath;
            openFiDi.Filter = "Solo Ficheros Json (*.json)|*.json";
            String ruta = @"..\..\JSON\" + idioma + a + ".json";
            if (idioma.Equals("") || idioma.Equals("ingles"))
            {
                JArray jarrayPreguntas = JArray.Parse(File.ReadAllText(ruta, Encoding.UTF8));
                listaMostrar = jarrayPreguntas.ToObject<BindingList<Pregunta>>();
                dataGridView1.DataSource = listaMostrar;
            }
            else if(idioma.Equals("catalan"))
            {
                
                JArray jarrayPreguntas = JArray.Parse(File.ReadAllText(ruta, Encoding.Default));
                listaMostrar = jarrayPreguntas.ToObject<BindingList<Pregunta>>();
                dataGridView1.DataSource = listaMostrar;
            }
        }

        private void GuardarEnJsonGeneros(String a, String idioma)
        {
            JArray arrayPreguntas = (JArray)JToken.FromObject(listaMostrar);
            File.WriteAllText(@"..\..\JSON\" + idioma + a + ".json", arrayPreguntas.ToString());
        }

        private void LimpiarFormulario()
        {
            textBoxPregunta.Text = "";
            textBoxResposta1.Text = "";
            textBoxResposta2.Text = "";
            textBoxResposta3.Text = "";
            textBoxResposta4.Text = "";
        }

        private string SeleccionarGenero(string gender)
        {
            if (radioButtonRock.Checked == true)
            {
                gender = radioButtonRock.Text;
            }
            else if (radioButtonHeavy.Checked == true)
            {
                gender = radioButtonHeavy.Text;

            }
            else if (radioButtonPop.Checked == true)
            {
                gender = radioButtonPop.Text;

            }
            else if (radioButtonRap.Checked == true)
            {
                gender = radioButtonRap.Text;

            }
            else if (radioButtonFunk.Checked == true)
            {
                gender = radioButtonFunk.Text;

            }

            return gender;
        }

        private string SeleccionarIdioma(String idioma)
        {
            if (radioButtonCastellano.Checked)
            {
                idioma = "";
            }
            else if (radioButtonCatalan.Checked)
            {
                idioma = "catalan";
            }
            else
            {
                idioma = "ingles";
            }


            return idioma;
        }

        private string SeleccionarDificultadPregunta(string dificul)
        {
            string dificult;
            if (radioButtonFacil.Checked == true)
            {
                dificult = "Facil";
            }
            else if (radioButtonMedio.Checked == true)
            {
                dificult = "Medio";
            }
            else
            {
                dificult = "Dificil";
            }

            return dificult;
        }

        private bool ControlCuartaPregunta(bool isTrueRes4)
        {
            if (radioButtonCiertoCuarto.Checked == true)
            {
                isTrueRes4 = true;
            }
            else if (radioButtonFalsoCuarto.Checked == true)
            {
                isTrueRes4 = false;
            }

            return isTrueRes4;
        }

        private bool ControlTerceraRespuesta(bool isTrueRes3)
        {
            if (radioButtonCiertoTercero.Checked == true)
            {
                isTrueRes3 = true;
            }
            else if (radioButtonFalsoTercero.Checked == true)
            {
                isTrueRes3 = false;
            }

            return isTrueRes3;
        }

        private bool ControlSegundaRespuesta(bool isTrueRes2)
        {
            if (radioButtonCiertoSegundo.Checked == true)
            {
                isTrueRes2 = true;
            }
            else if (radioButtonFalsoSegundo.Checked == true)
            {
                isTrueRes2 = false;
            }

            return isTrueRes2;
        }

        private bool ControlPrimeraRespuesta(bool isTrueRes1)
        {
            if (radioButtonCiertoPrimero.Checked == true)
            {
                isTrueRes1 = true;
            }
            else if (radioButtonFalsoPrimero.Checked == true)
            {
                isTrueRes1 = false;
            }

            return isTrueRes1;
        }

        private static Respuesta ObtenerObjetoRespuesta(string respuesta, bool isTrueRes)
        {
            Respuesta respuestaGuardar = new Respuesta(respuesta, isTrueRes);
            return respuestaGuardar;
        }

        private static List<Respuesta> AnadirLista(Respuesta a, Respuesta b, Respuesta c, Respuesta d)
        {
            List<Respuesta> respuestas = new List<Respuesta>();
            respuestas.Add(a);
            respuestas.Add(b);
            respuestas.Add(c);
            respuestas.Add(d);

            return respuestas;
        }

        private static Pregunta ObtenerObjetoPregunta(String pregunta, List<Respuesta> respuestas, String dificult, String gender)
        {
            Pregunta preguntaGuardar = new Pregunta(pregunta, respuestas, dificult, gender);
            return preguntaGuardar;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxAñadir_Enter(object sender, EventArgs e)
        {

        }

        private void JuegoAdmin_Load(object sender, EventArgs e)
        {
        }

        private void radioButtonHeavy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHeavy.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                ObtencionJsons(radioButtonHeavy.Text, idioma);
            }
        }

        private void radioButtonRock_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRock.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                ObtencionJsons(radioButtonRock.Text, idioma);
            }
        }

        private void radioButtonPop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPop.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                ObtencionJsons(radioButtonPop.Text, idioma);
            }
        }

        private void radioButtonRap_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRap.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                ObtencionJsons(radioButtonRap.Text, idioma);
            }
        }

        private void radioButtonFunk_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFunk.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                ObtencionJsons(radioButtonFunk.Text, idioma);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres borrarlo?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                Pregunta preguntaBorrar = (Pregunta)dataGridView1.CurrentRow.DataBoundItem;
                listaMostrar.Remove(preguntaBorrar);
                dataGridView1.DataSource = listaMostrar;
                GuardarEnJsonGeneros(preguntaBorrar.Gender, idioma);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            /*idioma = SeleccionarIdioma(idioma);*/

        }

        private void groupBoxGeneros_Enter(object sender, EventArgs e)
        {
            /*genere = SeleccionarGenero(genere);
            ObtencionJsons(genere, idioma);*/
        }

        private void radioButtonCatalan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCatalan.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                genere = SeleccionarGenero(genere);
                ObtencionJsons(genere, idioma);
            }
        }

        private void radioButtonCastellano_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCastellano.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                genere = SeleccionarGenero(genere);
                ObtencionJsons(genere, idioma);
            }
        }

        private void radioButtonIngles_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIngles.Checked == true)
            {
                idioma = SeleccionarIdioma(idioma);
                genere = SeleccionarGenero(genere);
                ObtencionJsons(genere, idioma);
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindingList<Pregunta> filtro = new BindingList<Pregunta>(listaMostrar.OrderBy(df => df.Dificult).ToList());
            dataGridView1.DataSource = filtro;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindingList<Pregunta> filtro = new BindingList<Pregunta>(listaMostrar.OrderByDescending(df => df.Dificult).ToList());
            dataGridView1.DataSource = filtro;
        }
    }
}
